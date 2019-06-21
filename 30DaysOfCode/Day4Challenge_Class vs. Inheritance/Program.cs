using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Challenge
{
    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge > 0)
            {
                age = initialAge;
            }
            else
            {
                Console.WriteLine("Age is not valid, setting age to 0.");//<== This really needs to break out and require user to enter valid age.
                age = 0;
            }// Add some more code to run some checks on initialAge
        }
        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }  // Do some computations in here and print out the correct statement to the console

        }
        public void yearPasses()
        {
            age++;   // Increment the age of the person in here
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            int age = int.Parse(Console.ReadLine());
            Person P1 = new Person(age);
            P1.amIOld();
            P1.yearPasses();
            Console.ReadKey();
        }
    }
}