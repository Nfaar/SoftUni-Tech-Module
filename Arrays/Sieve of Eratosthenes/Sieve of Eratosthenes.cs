using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new bool[n + 1];

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            var p = 0;
            for (int i = 0; i <= n; i++)
            {
                if (!arr[i])
                {
                    continue;
                    
                }

                for (int j = 2 * i; j <= n; j += i)
                {
                    arr[p] = false;
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
