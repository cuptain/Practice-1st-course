///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №5 (692 - к).
/// Находит наибольший элемент, находящийся под побочной диагональю
/// матриы заданного порядка
/// 

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
            Console.WriteLine("Доброго времени суток!\nДанная программа находит наибольший элемент, находящийся под побочной диагональю\n" +
                "матрицы заданного порядка (от 1 до 100)\nПриятного пользования!\n");
            Console.WriteLine("Введите порядок матрицы (больше 0 и меньше 101)");

            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out size);
                if (!ok || size <= 0 || size >= 101)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nОшибка! Порядок матрицы должен быть числом > 0 и < 101\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!ok || size <= 0 || size >= 101);

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
                Console.WriteLine("\n");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nМаксимальное число = {0}", max);
            Console.ReadKey();

        }
    }
}
