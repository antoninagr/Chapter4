using System;

namespace _09_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d < 0)
                Console.WriteLine(
                   "This equation has no real solutions.");
            else if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0:f4}; x2 = {1:f4}", x1, x2);
            }
            else // d == 0
            {
                double x = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0:f4}", x);
            }
        }
    }
}
