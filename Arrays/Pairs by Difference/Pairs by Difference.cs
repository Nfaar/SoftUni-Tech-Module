using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var n = int.Parse(Console.ReadLine());

            var cnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == n)
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
