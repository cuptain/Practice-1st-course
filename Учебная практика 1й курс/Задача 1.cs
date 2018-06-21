///
/// Василюк Василий, ПИ-17-1, уч. практика 1 курс, 2017-18 гг.
/// Задача №1 (348 на сайте).
/// Проверяет, пересекаются ли отрезки, заданные координатами четырёх точек
/// 

using System;
using System.IO;


namespace Учебная_практика_1й_курс
{
    public class Point //Класс точка
    {
        long x { get; set; } // Координата Х
        long y { get; set; } // Координата Y

        public Point(long newX = 0, long newY = 0) //Конструктор
        {
            x = newX;
            y = newY;
        }

        //Функция проверки на пересекаемость
        public static bool Check(Point p1, Point p2, Point p3, Point p4)
        {
            long tg, b, Xa, Ya;

            //Расположение точек первого отрезка по порядку
            if (p2.x < p1.x)
            {
                Point tmp = p1;
                p1 = p2;
                p2 = tmp;
            }

            //Расположение точек второго отрезка по порядку
            if (p4.x < p3.x)
            {
                Point tmp = p3;
                p3 = p4;
                p4 = tmp;
            }

            //Проверка расположений концов отрезка
            if (p2.x < p3.x)
                return false;

            //Если оба отрезка вертикальные
            if ((p1.x - p2.x == 0) && (p3.x - p4.x == 0))
            {
                if (p1.x == p3.x) //Лежат ли на одной абсциссе
                    if (!((Math.Max(p1.y, p2.y) < Math.Min(p3.y, p4.y)) || (Math.Min(p1.y, p2.y) > Math.Max(p3.y, p4.y)))) //Есть ли общая ордината
                        return true;
                return false;
            }

            //Если первый отрезок вертикальный
            if (p1.x - p2.x == 0)
            {
                Xa = p1.x;
                tg = (p3.y - p4.y) / (p3.x - p4.x);
                b = p3.y - tg * p3.x;
                Ya = tg * Xa + b;
                if (p3.x <= Xa && p4.x >= Xa && Math.Min(p1.y, p2.y) <= Ya && Math.Max(p1.y, p2.y) >= Ya)
                    return true;
                return false;
            }
             //Если второй отрезок вертикальный
            if (p3.x - p4.x == 0)
            {
                Xa = p3.x;
                tg = (p1.y - p2.y) / (p1.x - p2.x);
                b = p1.y - tg * p1.x;
                Ya = tg * Xa + b;
                if (p1.x <= Xa && p2.x >= Xa && Math.Min(p3.y, p4.y) <= Ya && Math.Max(p3.y, p4.y) >= Ya)
                    return true;
                return false;
            }

            //Оба отрезка не вертикальные
            long A1 = (p1.y - p2.y) / (p1.x - p2.x);
            long A2 = (p3.y - p4.y) / (p3.x - p4.x);
            long b1 = p1.y - A1 * p1.x;
            long b2 = p3.y - A2 * p3.x;
            if (A1 == A2) // Паралелльный
                return false;
            Xa = (b2 - b1) / (A1 - A2); //Абсцисса пересечения
            if ((Xa < Math.Max(p1.x, p3.x)) || (Xa > Math.Min(p2.x, p4.x))) //Находится ли абсциса в пересечении проекций отрезков на ось
                return false;
            else
                return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            bool ans;
            StreamReader sr = new StreamReader("INPUT.TXT");
            string[] str = sr.ReadLine().Split(' ');
            Point p1 = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            str = sr.ReadLine().Split(' ');
            Point p2 = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            str = sr.ReadLine().Split(' ');
            Point p3 = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            str = sr.ReadLine().Split(' ');
            Point p4 = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            ans = Point.Check(p1, p2, p3, p4);
            if (ans)
                answer = "Yes";
            else
                answer = "No";
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(answer);
            sw.Dispose();
            sr.Dispose();
        }
    }
}
