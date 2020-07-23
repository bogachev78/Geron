using System;

namespace Geron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины трех сторон треугольника");
            double one = Double.Parse(Console.ReadLine());
            double two = Double.Parse(Console.ReadLine());
            double three = Double.Parse(Console.ReadLine());

            double p = 0.5 * (one + two + three);
            double s = Math.Sqrt(p * (p - one) * (p - two) * (p - three));
            Console.WriteLine($"Площадь трейгольни со сторонами {one}, {two}, {three} равна: {s}");
        }
    }
}
