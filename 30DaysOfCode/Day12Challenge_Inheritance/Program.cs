using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //In order for this sln to work, HackerRank formats all the classes together into one "project".

            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = int.Parse(inputs[2]);
            int numScores = int.Parse(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine($"Grade: " + s.Calculate() + "\n");

            Console.ReadKey();
        }
    }
}
