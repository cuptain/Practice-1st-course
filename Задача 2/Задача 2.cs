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
        static double[][] digits { get; set; } // коэффициенты, цифры и степени 10
        static long code;
        static long result = 0;

        private static string ToPattern(string num)
        {
            while (num.Length < digits.Length)
                num = "0" + num;
            return num;
        }

        private static string ToAnswer(string num)
        {
            while (num[0] == '0')
                num = num.Remove(0, 1);
            return num;
        }

        public static void Coefs(int size, int k)
        {
            digits = new double[size][];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = new double[3];
                digits[i][1] = digits.Length - 1 - i;
            }
            int x = digits.Length;
            for (int i = 0; i < digits.Length; i++)
                digits[i][2] = Math.Pow(10, digits[i][1]) + Math.Pow(10, digits[Sdvig(digits.Length, k, i)][1]);
        }

        public static void Perebor(int pow)
        {
            for (double i = Math.Pow(10, pow); i < Math.Pow(10, digits.Length) - 1; i++)
            {
                result = 0;
                for (int j = 0; j < digits.Length; j++)
                {
                    digits[j][0] = Convert.ToDouble(ToPattern(i.ToString())[j].ToString());
                    result += (long)(digits[j][0] * digits[j][2]);
                }
                if (result == code)
                    break;
            }
        }

        private static int Sdvig(int size, int k, int pos) //подбор коэффициентов
        {
            int num = pos - k;
            if (pos == 0)
                num = size - k;
            if(num < 0)
            {
                int i = num;
                num = size + num;
            }
            return num;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            code = (long)Convert.ToDouble(sr.ReadLine());
            int k = Convert.ToInt32(sr.ReadLine());
            string answer = "";
            if (Math.Pow(10,code.ToString().Length - 2) >= Math.Pow(10,1 + k))
            {
                Coefs(code.ToString().Length - 1, k);
                Perebor(digits.Length - 1);
                if (result != code)
                {
                    Coefs(code.ToString().Length, k);
                    Perebor(digits.Length - 1);
                }
            }
            else
            {
                Coefs(code.ToString().Length, k);
                Perebor(digits.Length - 1);
            }
            for (int i = 0; i < digits.Length; i++)
                answer += digits[i][0].ToString();
            answer = ToAnswer(answer);
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine((long)Convert.ToDouble(answer));
            sw.Dispose();
            sr.Dispose();
        }
    }
}
