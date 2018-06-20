///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №8 (вариант 7).
/// Определяет является ли граф, заданный таблицей смежностей деревом
/// 

using System;

namespace Задача_8
{
    class Program
    {
        //Ввод целых чисел
        private static int Input(string task)
        {
            int number;
            bool ok = false;
            do
            {
                Console.WriteLine(task);
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ввод неправильный, нужно ввести целое число. Повторите попытку:\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!ok);
            return number;
        }

        //Ввод числа в гранях
        private static int ReadVGran(int min, int max, string task, string name = null)
        {
            int chislo;
            do
            {
                chislo = Input(task);
                if (chislo <= min || chislo >= max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! " + name + " должен(-но) быть больше, чем {0} и меньше, чем {1}. Попробуйте ещё раз:\n", min, max);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (chislo <= min || chislo >= max);
            return chislo;
        }

        private static bool Check() //Проверка на связность
        {
            int count = 0;
            for (int i = 0; i < kolVer; i++)
            {
                for (int j = 0; j < kolVer; j++)
                    if (matrix[i, j] == 0)
                        count++;
                if (count == 4)
                    return false;
                else
                    count = 0;
            }
            return true;
        }

        static int kolVer { get; set; } //Количество вершин
        static int[,] matrix { get; set; } //Матрица смежностей

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Доброго времени суток!\nДанная программа определяет, является ли граф, заданный таблицей смежности, деревом" +
                "\nПриятного пользования!\n");
            int kolReb = 0;
            kolVer = ReadVGran(0, 101, "Введите количество вершин графа:", "Количество вершин графа");
            matrix = new int[kolVer, kolVer];
            for (int i = 0; i < kolVer; i++)
                for (int j = 0; j < i; j++)
                {
                    matrix[i, j] = matrix[j, i] =
                          ReadVGran(-1, 2, "Введите 1, если вершина " + (j + 1) + " и вершина " + (i + 1) + " связаны, или введите 0, если нет:", "Ответ");
                    if (matrix[i, j] == 1)
                        kolReb++;
                }

            if (kolVer - kolReb == 1)
            {
                if (Check())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nДанный граф является деревом");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nДанный граф не является деревом");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nДанный граф не является деревом");
            }
            Console.ReadKey();

        }
    }
}
