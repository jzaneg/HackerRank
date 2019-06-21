using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Challenge
    {
        class Program
        {
        static void Main(string[] args)
        {
            //https://www.hackerrank.com/challenges/30-arrays/problem  <== LINK TO PROBLEM
            //Given an array, 'A', of 'N' integers
            //print A's elements in reverse order as a single line
            //As space-separated numbers. 

            Console.WriteLine("Please enter a value for the number of items in the Array.");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter values for the Array seperated by a space.");
            string[] A = Console.ReadLine().Split(' ').ToArray(); //<== Takes the user input and splits it by whitespace and converts the result to an array.
            string rev = "";

            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    rev += A[i] + " ";
                }
                else
                {
                    rev += A[i];
                }
            }
            Console.Write(rev);
            Console.ReadKey();
            }
        }
    }
