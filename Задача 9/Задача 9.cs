///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №9 (вариант 13).
/// Реализует рекурсивное создание циклического списка,
/// а также рекурсивыне методы поиска и удаления элемента.
/// 

using System;

namespace Задача_9
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

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Доброго времени суток!\nДанная программа реализует рекурсивные методы создания циклического списка\n" +
                "а также поиска и удаления элементов\nПриятного пользования!\n");
            int N = ReadVGran(0,101,"Введите количество элементов списка (N):", "Количество элементво списка");
            Console.WriteLine("\nСозданный список: ");
            CycleList cycleList = new CycleList();
            cycleList.CreateCircularList(N);
            cycleList.Show();
            Console.WriteLine("\n");

            int value = Input("Введите элемент, который хотите найти:");
            Point wanted = cycleList.Search(value, cycleList.head, cycleList.tail);
            if (wanted.next == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВ списке нет элемента с введённым значением");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nНайденный элемент: {0}\nСледующий элемент: {1}", wanted.data, wanted.next.data);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            value = Input("Введите элемент, который хотите удалить из списка:");
            cycleList.head = cycleList.Remove(value, cycleList.tail, cycleList.head, cycleList.tail);
            Console.WriteLine("\nПолучившийся список:\n");
            cycleList.Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nДля выхода нажмите клавишу Enter...");
            Console.CursorVisible = false;
            Console.ReadLine();
        }
    }
}
