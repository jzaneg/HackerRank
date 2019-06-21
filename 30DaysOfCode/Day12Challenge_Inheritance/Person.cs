using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Challenge
{
    public class Person
    {
        public string fn { get; set; }
        public string ln { get; set; }
        public int id { get; set; }

        public Person(string firstName, string lastName, int identification)
        {
            fn = firstName;
            ln = lastName;
            id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine($"Name: " + this.fn + ", " + this.ln + "\nID: " + this.id);
        }
    }
}
