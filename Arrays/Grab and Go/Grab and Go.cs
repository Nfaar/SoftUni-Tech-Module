using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var n = long.Parse(Console.ReadLine());

            long index = 0;
            long sum = 0;

            var found = false;

            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    index = i;
                    found = true;
                }
            }
            for (long i = 0; i < index; i++)
            {
                sum += arr[i];

            }


            if (found)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
