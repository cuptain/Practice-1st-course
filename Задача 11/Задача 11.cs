﻿///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №11 (838).
/// Шифрует и расшифровывает последовательность симовлов,
/// при помощи решётки Кардано
/// 

using System;
using System.IO;

namespace Задача_11
{
    class Program
    {
        const int order = 10;

        private static int[] ReadValue(out bool ok, string data) //Чтение матрицы по строкам с проверкой
        {
            ok = true;
            int[] digits = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
                digits[i] = Convert.ToInt32(data[i]) - 48;
            for (int i = 0; i < digits.Length; i++)
                if ((digits[i] != 0) && (digits[i] != 1))
                    ok = false;
            return digits;
        }

        static int[][] ReadMatrix(StreamReader inputMatrix, out bool okReading) //чтение матрицы из файла
        {
            int[][] matrix = new int[order][];
            okReading = true;

            try
            {
                for (int row = 0; row < order && okReading; row++)
                {
                    string data = inputMatrix.ReadLine();
                    matrix[row] = ReadValue(out okReading, data);

                    if (!okReading)
                        Console.WriteLine("В матрице обнаружено значение, отличное от \"0\" и \"1\"");

                    else if (matrix[row].Length != order)
                    {
                        okReading = false;
                        Console.WriteLine("В матрице обнаружена строка с количеством элементов, не равным " + order);
                    }
                }
            }
            catch (Exception)
            {
                okReading = false;
                Console.WriteLine("Ошибка чтения матрицы \nПроверьте количество строк и значения");
            }

            if (okReading)
            {
                okReading = CheckMatrix(matrix);

                if (!okReading)
                    Console.WriteLine("Матрица не может быть ключом");
            }

            inputMatrix.Close();
            return matrix;
        }

        static bool CheckMatrix(int[][] matrix) // проверка пригодности матрицы быть ключом
        {
            if (CheckMatrixValues(matrix))
            {

                for (int row = 0; row < order / 2; row++)
                    for (int column = 0; column < order / 2; column++)
                    {
                        if (matrix[row][column] + matrix[column][order - 1 - row] // поскольку среди этих только
                            + matrix[order - 1 - row][order - 1 - column]         // одно значение 0, а остальные 1, 
                            + matrix[order - 1 - column][row] != 3)               // то сумма только 3
                        {
                            return false;
                        }
                    }

            }
            else
            {
                Console.WriteLine("В матрице обнаружено значение, отличное от 0 и 1");
                return false;
            }

            return true;
        }

        static bool CheckMatrixValues(int[][] matrix) // проверка значений матрицы (0 или 1) 
        {
            bool okValues = true;

            for (int row = 0; row < order; row++)
            {
                for (int column = 0; column < order; column++)
                    if (matrix[row][column] != 0 && matrix[row][column] != 1)
                    {
                        okValues = false;
                        break;
                    }

                if (!okValues)
                    break;
            }

            return okValues;
        }

        static string ReadString(StreamReader inputString, out bool okReading) // чтение строки для шифрования и дешифрования
        {
            string symbols = string.Empty;
            okReading = true;

            try
            {
                symbols = inputString.ReadLine();
                inputString.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка чтения последовательности");
                okReading = false;
            }

            if (symbols == null || okReading && symbols.Length != 100)
            {
                okReading = false;
                Console.WriteLine("Количество символов последовательности не равно 100");
            }

            return symbols;
        }

        static string Encrypt(int[][] matrix, string symbols) //шифрование последовательности symbols решеткой matrix
        {
            int currentSymbol = 0;
            string result = string.Empty;

            char[][] cryptMatrix = new char[order][];

            for (int row = 0; row < order; row++)
                cryptMatrix[row] = new char[order];

            for (int turn = 1; turn <= 4; turn++)
            {
                // запись символов в свободные клетки
                for (int row = 0; row < order; row++)
                    for (int column = 0; column < order; column++)
                        if (matrix[row][column] == 0)
                        {
                            cryptMatrix[row][column] = symbols[currentSymbol];
                            currentSymbol++;
                        }

                //поворот матрицы
                TurnMatrix(ref matrix);
            }

            result = ReadEncryptResult(cryptMatrix);

            return result;
        }

        static void TurnMatrix(ref int[][] matrix) //поворот матрицы на 90 градусов по часовой стрелке 
        {
            for (int row = 0; row < order / 2; row++)
                for (int column = 0; column < order / 2; column++)
                {
                    int temp = matrix[row][column];
                    matrix[row][column] = matrix[column][order - 1 - row];
                    matrix[column][order - 1 - row] = matrix[order - 1 - row][order - 1 - column];
                    matrix[order - 1 - row][order - 1 - column] = matrix[order - 1 - column][row];
                    matrix[order - 1 - column][row] = temp;
                }
        }

        static string ReadEncryptResult(char[][] matrix) // чтение зашифрованной последовательности 
        {
            string result = string.Empty;

            for (int row = 0; row < order; row++)
                for (int column = 0; column < order; column++)
                    result += matrix[row][column].ToString();

            return result;
        }

        static string Decipher(int[][] matrix, string code) // дешифрование последовательности code матрицей matrix
        {
            char[][] codeMatrix = new char[order][];
            int currentSymbol = 0;

            // запись последовательности в матрицу
            for (int row = 0; row < order; row++)
            {
                codeMatrix[row] = new char[order];

                for (int column = 0; column < order; column++)
                {
                    codeMatrix[row][column] = code[currentSymbol];
                    currentSymbol++;
                }
            }

            string result = string.Empty;

            for (int turn = 1; turn <= 4; turn++)
            {
                for (int row = 0; row < order; row++)
                    for (int column = 0; column < order; column++)
                        if (matrix[row][column] == 0)
                            result += codeMatrix[row][column].ToString();

                //поворот матрицы
                TurnMatrix(ref matrix);
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[0][];
            string symbols = string.Empty;
            bool okReading;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Доброго времени суток!\nДанная программа шифрует расшифровывает заданную последовательность (string.txt)\n" +
                "при помощи заданной матрицы-ключа (matrix.txt)\nПриятного пользования!");

            try
            {
                using (StreamReader inputMatrix = new StreamReader("matrix.txt"))
                {
                    matrix = ReadMatrix(inputMatrix, out okReading);
                }
            }
            catch (Exception)
            {
                okReading = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка чтения матрицы");
            }

            if (okReading)
            {
                try
                {
                    using (StreamReader inputString = new StreamReader("string.txt"))
                        symbols = ReadString(inputString, out okReading);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nОшибка чтения последовательности");
                    okReading = false;
                }

                if (okReading)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string cryptSymbols = Encrypt(matrix, symbols);
                    Console.WriteLine("\nЗашифрованная последовательность:\n" + cryptSymbols);

                    string decryptedSymbols = Decipher(matrix, symbols);
                    Console.WriteLine("\nРасшифрованная последовательность:\n" + decryptedSymbols);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nНажмите Enter для завершения работы программы...");
            Console.ReadLine();
        }
    }
}
