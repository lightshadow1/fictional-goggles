using System;

namespace Fibonacci_Generator
{
    class Program
    {
        public static void GenerateFibonacciRecursively(int num, int val1 = 1, int val2 = 1)
        {
            if (num > 0)
            {
                num--;
                Console.WriteLine(val1);
                GenerateFibonacciRecursively(num, val2, val1 + val2);
            }
        }

        static void Main()
        {
            Console.WriteLine("Print n Fibonacci Numbers!");
            Console.WriteLine("Enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            GenerateFibonacciRecursively(n);
        }
    }
}
