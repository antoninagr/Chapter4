using System;

namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int natural;
            double positive, negative;

            Console.Write("Number = ");
            natural = int.Parse(Console.ReadLine());
            Console.Write("Positive real number = ");
            positive = double.Parse(Console.ReadLine());
            Console.Write("Negative real number = ");
            negative = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10:x}{1,-10:f2}{2,-10:f2}",
               natural, positive, negative);


        }
    }
}
