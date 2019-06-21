using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of your number {N} is {factorial(N)}");
            Console.ReadKey();
        }
        public static int factorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            else
            {
                return N * factorial(N - 1);
            }
        }
    }
}
