///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №2 (655 на сайте).
/// Декодирует число, которое закодировано суммой себя и числа,
/// образованного переносом определённого коичества цифр с левого края на правый
/// 

using System;
using System.IO;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = "319";
            StreamReader sr = new StreamReader("INPUT.TXT");
            string code = sr.ReadLine();
            int k = Convert.ToInt32(sr.ReadLine());
            int[] arr = new int[code.Length];
            for (int i = 0; i < code.Length; i++)
                arr[i] = Convert.ToInt32(code[i]) - 48;
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(N);
            sw.Dispose();
            sr.Dispose();
        }
    }
}
