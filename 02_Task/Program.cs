using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter circle's radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * (r * r);
            double perim = Math.PI * (2 * r);
            Console.WriteLine("The area of the circle is: {0}\nThe perimeter of circle is {1}", area, perim);
        }
    }
}
