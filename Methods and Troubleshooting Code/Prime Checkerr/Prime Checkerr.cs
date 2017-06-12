using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checkerr
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            PrintPrimeNum(n);
        }

        private static void PrintPrimeNum(long i)
        {
            if (i == 0 || i == 1)
            {
                Console.WriteLine(false);
            }
            else
            {
                for (int a = 2; a <= i / 2; a++)
                {
                    if (i % a == 0)
                    {
                        Console.WriteLine(false);

                        return;
                    }

                }
                Console.WriteLine(true);
            }
        }
    }
}
