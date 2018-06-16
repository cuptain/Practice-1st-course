using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, U;
            bool ok;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("Введите x:");
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (!ok)
                    Console.WriteLine("Ошибка числового ввода, попробуйте ещё раз.");
            } while (!ok);

            do
            {
                Console.WriteLine("Введите y:");
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out y);
                if (!ok)
                    Console.WriteLine("Ошибка числового ввода, попробуйте ещё раз.");
            } while (!ok);

            
            bool area = (y <= 1-Math.Pow(x,2)) && (Math.Pow(x, 2) + Math.Pow(y - 1, 2) <= 1);
            if (area)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                U = x - y;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                U = x * y + 7;
            }
            Console.WriteLine("U = {0}", U);
            Console.ReadKey();
        }
    }
}
