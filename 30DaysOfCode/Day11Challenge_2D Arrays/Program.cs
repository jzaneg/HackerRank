using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Array2D = new int[6][];

            for (int i = 0; i <= 5; i++)
            {
                var tempArr = Console.ReadLine().Split(' ');
                Array2D[i] = Array.ConvertAll(tempArr, int.Parse);
            }
            int total = 0;
            int HGT = -9 * 7; //hourglass total: all numbers are greater than -9 with 7 total nums in hourglass
            int x, y;

            for (x = 0; x <= 5; x++)
            { 
                for (y = 0; y <= 5; y++)
                {
                    if ((y + 2 <= 5) && (x + 2 <= 5))
                    {
                        total = Array2D[x][y] + Array2D[x][y + 1] + Array2D[x][y + 2] + Array2D[x + 1][y + 1] + Array2D[x + 2][y] + Array2D[x + 2][y + 1] + Array2D[x + 2][y + 2];  
                        if (total > HGT)
                        {
                            HGT = total;
                        }
                    }
                }
            }
            Console.WriteLine(HGT);
            Console.ReadKey();
        }
    }
}
