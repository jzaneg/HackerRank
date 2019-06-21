using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Challenge
{
    class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
        {
            this.testScores = testScores;
        }

        public char Calculate()
        {
            int average;
            int sum = 0;
            char grade = 'x';

            foreach (int score in testScores)
            {
                sum += score;
            }

            average = testScores.Sum() / testScores.Count();

            if (average >= 90 && average <= 100)
            {
                grade = 'O';
            }
            else if (average >= 80 && average < 90)
            {
                grade = 'E';
            }
            else if (average >= 70 && average < 80)
            {
                grade = 'A';
            }
            else if (average >= 55 && average < 70)
            {
                grade = 'P';
            }
            else if (average >= 40 && average < 55)
            {
                grade = 'D';
            }
            else if (average < 40)
            {
                grade = 'T';
            }
            return grade;
        }
	}
}
