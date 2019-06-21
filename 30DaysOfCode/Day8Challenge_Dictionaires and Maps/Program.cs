using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUMMARY//
            Console.WriteLine("Please enter how many phonebook entries there are.");
            int n = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Please enter the person's name and phone number. Press enter after each name.");

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            
            
            for (int i = 0; i < n; i++)
            {
                string[] nameNumber = Console.ReadLine().Split(' ').ToArray();
                phoneBook.Add(nameNumber[0], nameNumber[1]);
            }
            string nameQuery = Console.ReadLine();
            while (!string.IsNullOrEmpty(nameQuery))
            {
                if (phoneBook.ContainsKey(nameQuery))
                {
                    Console.WriteLine($"{nameQuery}={phoneBook[nameQuery]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                nameQuery = Console.ReadLine();
            }
            //THE BELOW DOES NOT WORK DUE TO REQUIRING UNKNOWN NUMBER OR QUERIES//
            //foreach (KeyValuePair<string, string> kvp in phoneBook)
            //    {
            //        if (!phoneBook.ContainsKey(Console.ReadLine()))
            //        {
            //            Console.WriteLine("Not found");
            //        }
            //        else
            //        {
            //            Console.WriteLine(kvp.Key + "=" + kvp.Value);
            //        }
            //    }
            Console.ReadKey();
        }
    }
}
