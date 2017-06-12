using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var array = new int[n];
            array[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                var sum = 0;
                for (int j = i - k; j <= i - 1 ; j++)
                {
                    if (j >= 0)
                    {
                        sum += array[j];
                    }
                    array[i] = sum;
                }

            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
