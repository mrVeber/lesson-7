using System;

namespace lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте стороны первого треугольника: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Задайте стороны второго треугольника: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int p1 = CalcSemiP(a1, b1, c1);
            int p2 = CalcSemiP(a2, b2, c2);

            if (CalcArea(a1, b1, c1, p1) > CalcArea(a2, b2, c2, p2))
            {
                Console.WriteLine($"Площадь первого треугольника больше {CalcArea(a1, b1, c1, p1)} площадь второго:{CalcArea(a2, b2, c2, p2)}");
            }
            else
            {
                Console.WriteLine($"Площадь второго треугольника больше {CalcArea(a2, b2, c2, p2)} площадь первого:{CalcArea(a1, b1, c1, p1)}");
            }
            Console.ReadKey();
        }
        static int CalcSemiP (int a, int b, int c)
        {
            int p;
            p = (a + b + c) / 2;
            return p;
        }

        static double CalcArea (int a, int b, int c, int p)
        {
            double s;
            s = (double)Math.Sqrt(Math.Abs(p * (p - a) * (p - b) * (p - c)));
            return s;
        }

    }
}
