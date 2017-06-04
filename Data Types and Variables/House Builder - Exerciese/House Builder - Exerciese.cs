using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Builder___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = long.Parse(Console.ReadLine());
            var second = long.Parse(Console.ReadLine());

            long sumRoof = 0;
            long sumAllWithoutRoof = 0;

            if (first >= sbyte.MinValue && first <= sbyte.MaxValue)
            {
                sumRoof = first * 4;
                sumAllWithoutRoof = second * 10;
            }
            else
            {
                sumRoof = second * 4;
                sumAllWithoutRoof = first * 10;
            }
            Console.WriteLine(sumAllWithoutRoof + sumRoof);
        }
    }
}
