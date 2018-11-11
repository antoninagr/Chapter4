using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N-numbers to be summed: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            Console.WriteLine("Please enter the numbers: ");
            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of entered numbers is {0}\n", sum);
        }
    }
}
