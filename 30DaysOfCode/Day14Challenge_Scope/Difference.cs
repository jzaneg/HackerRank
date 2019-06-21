using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Challenge
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            this.elements = a;
        }
        
        public int computeDifference()
        {
            int diff;
            int i, j;

            for (i = 0; i <= elements.Length -1; i++)
            {
                for (j = 0; j <= elements.Length - 1; j++)
                {
                    diff = Math.Abs(elements[j] - elements[i]);
                    if (diff > maximumDifference)
                    {
                        maximumDifference = diff;
                    }
                }
            }
            return(maximumDifference);
        }
    }
}
