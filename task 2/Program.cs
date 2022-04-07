using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну ребра куба: ");
            int ribLen = Convert.ToInt32(Console.ReadLine());
            double V, S;

            VolArCalc(ribLen, out V, out S);

            Console.Write($"Площадь куба равна: {S}");
            Console.Write($"\nОбъём куба равен: {V}");
            Console.ReadKey();
        }

        static void VolArCalc (int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 6);
        }
    }
}
