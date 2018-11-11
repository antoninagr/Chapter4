using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first positive intiger number: ");
            uint a = uint.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second positive intiger number: ");
            uint b = uint.Parse(Console.ReadLine());

            int count = 0;

            for (int i = (int)a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Numbers p that exist in the interval {0} to {1} are: {2}", a, b, count);
        }
    }
}
