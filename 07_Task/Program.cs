using System;

namespace _07_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, sum = 0, max = 0;
            int count = 5;
            bool isValid;

            do
            {
                Console.Write("Input a real number = ");
                isValid = double.TryParse(Console.ReadLine(), out x);
                if (isValid)
                {
                    sum += x;
                    max = (max < x || count == 5 ? x : max);
                    count--;
                }
                else
                    Console.WriteLine("Invalid number. Try another one!");
            }
            while (count > 0);

            Console.WriteLine("Sum = " + sum);

        }
    }
}
