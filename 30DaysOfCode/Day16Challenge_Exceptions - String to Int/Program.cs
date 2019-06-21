using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a string 'S'
            //Print 'S' int value
            //If 'S' can't be converted to int, print "Bad String"
            //1 <= S <= 6 where 'S' equals length of string
            string S = Console.ReadLine();
            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (FormatException)
            {
                Console.Write("Bad String");
            }
            Console.ReadKey();
        }
    }
}
