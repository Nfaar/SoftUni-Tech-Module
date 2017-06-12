using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var k = num.Length / 4;
            var topRow = new int[2 * k];
            
            var sum = new int[num.Length / 2];

            for (int i = 0; i < k; i++)
            {
                topRow[i] = num[num.Length - 1 - i - 3 * k];
                topRow[topRow.Length - 1 - i] = num[num.Length + i - k];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = topRow[i] + num[i + k];
            }



            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
