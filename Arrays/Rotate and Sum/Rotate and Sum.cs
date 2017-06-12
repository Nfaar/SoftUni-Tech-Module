using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var k = int.Parse(Console.ReadLine());


            var sum = new int[n.Length];


            for (int i = 0; i < k; i++)
            {
                int tempInt = n[n.Length - 1];
                for (int r = n.Length - 1; r > 0; r--)
                {
                    n[r] = n[r - 1];

                }
                n[0] = tempInt;
                for (int j = 0; j < n.Length; j++)
                {
                    sum[j] += n[j];
                }

            }



            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
