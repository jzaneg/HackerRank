using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Challenge
{
    class Program
    {
        //Objective 
            //Today, we're working with binary numbers. Check out the Tutorial tab for learning materials and an instructional video!
        //Task
            //Given a base-10 integer, n, convert it to binary(base-2). Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.
        //Input Format
            //A single integer, n.
        //Constraints
            //1 <= n <= 10^6
        //Output Format
            //Print a single base-10 integer denoting the maximum number of consecutive 1's in the binary representation of n.
        //Explanation
            //Sample Case 1: 
            //The binary representation of 5 is 101, so the maximum number of consecutive 1's is 1.
            //Sample Case 2: 
            //The binary representation of 13 is 1101, so the maximum number of consecutive 1's is 2.

        public static void returnBase()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binaryNum = Convert.ToString(n, 2);
            int result = 0;
            int maxOnes = 0;
            //Delete this line when submitting in HackerRank Solution
            Console.WriteLine($"{binaryNum}");

            foreach (char num in binaryNum)
            {
                if (num.Equals('1'))
                {
                    result++;
                    if (maxOnes < result)
                    {
                        maxOnes = result;
                    }
                }
                else if (num == '0')
                {
                    result = 0;
                }
            }
            //For HackerRank solution just print to screen:
            //Console.WriteLine($"{maxOnes}");
            Console.WriteLine($"The max number of consecutive ones is: {maxOnes}.");
        }

        static void Main(string[] args)
        {
            returnBase();
            Console.ReadKey();
        }
    }
}
