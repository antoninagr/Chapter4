using System;

namespace _12_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            byte count = 2;
            decimal a = 0, b = 1;

            Console.WriteLine("{1,10}.{0,30:n0}; ", a, 1);
            Console.WriteLine("{1,10}.{0,30:n0}; ", b, 2);
            do
            {
                count++;
                b = a + b;
                a = b - a;
                Console.WriteLine("{1,10}.{0,30:n0}; ", b, count);
            }
            while (count < 100);



        }
    
    }
}
