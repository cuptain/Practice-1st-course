using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            bool ok;
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите размерность матрицы (больше 0)");

            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out size);
                if (!ok || size <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nОшибка числового ввода, попробуйте ещё раз.");
                }
            } while (!ok || size <= 0);

            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next(10, 100);

            int m = 0;
            int max = matrix[size - 1, 0];
            for (int i = size - 1; i >= 0; i--)
            {
                for (int j = m; j < size; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                m++;
            }

            Console.WriteLine("Матрица имеет вид:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + "  ");
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nМаксимальное число = {0}", max);
            Console.ReadKey();

        }
    }
}
