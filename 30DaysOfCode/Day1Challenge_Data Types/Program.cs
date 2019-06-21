using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            // Declare second integer, double, and String variables.
            int i2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            string s2 = Console.ReadLine();
            // Read and save an integer, double, and String to your variables.
            int iSum = i + i2;
            double dSum = d + d2;
            string sSum = s + s2;
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(iSum);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(dSum.ToString("F1"));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(sSum);
            // The 's' variable above should be printed first.
            Console.ReadKey();
        }
    }
}
