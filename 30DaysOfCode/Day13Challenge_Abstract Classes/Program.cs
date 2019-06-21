using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
