using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var currentLen = 1;
            var start = 0;

            var bestLen = 0;
            var bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i-1] >= 1)
                {
                    currentLen++;
                    start = i;
                    if (bestLen < currentLen)
                    {
                        bestLen = currentLen;
                        bestStart = start;
                    }
                }
                else
                {
                    currentLen = 1;
                    start = 0;
                }
            }


            for (int i = bestStart - bestLen + 1; i <= bestStart; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
