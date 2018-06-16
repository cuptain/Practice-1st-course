﻿using System;

namespace Задача_4
{
    class Program
    {
        //Факториал
        public static double Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            double e; bool ok;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введтие нужную точность (больше нуля)");

            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out e);
                if (!ok || e <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nОшибка числового ввода, попробуйте ещё раз.");
                }
            } while (!ok || e<=0);

            double sum = 1, prevSum = 1;
            int count = 1;

            do
            {
                prevSum = sum;
                sum += (Math.Pow(-2, count))/Factorial(count);
                count++;
            } while (Math.Abs(sum - prevSum) > e);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nИтоговая сумма = {0}", prevSum);
            Console.ReadKey();
        }
    }
}
