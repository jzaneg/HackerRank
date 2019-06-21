using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
        //SUMMARY//
        //LINK TO PROBLEM//
        //https://www.hackerrank.com/challenges/30-review-loop/problem

            Console.WriteLine("Please enter the number of test cases.");//<== You don't need this step when submitting to HR.
            int N = int.Parse(Console.ReadLine()); 
            indexString(N);
            Console.ReadKey();
        }
        static void indexString(int N)
        {
            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                string even ="";
                string odd = "";

                for (int j = 0; j < S.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        even += S[j];
                    }
                }
                for (int k = 0; k < S.Length; k++)
                {
                    if (k % 2 != 0)
                    {
                        odd += S[k];
                    }
                }
                Console.WriteLine(even +" "+ odd);
            }
        }
    }
}

