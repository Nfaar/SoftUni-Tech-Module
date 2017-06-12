using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var move = true;

            var sum = arr[0];

            var start = 0;

            while (move)
            {
                var moving = arr[start];

                if (start + moving < arr.Length)
                {
                    sum += arr[start + moving];

                    start = start + moving;
                }
                else if (start - moving >= 0)
                {
                    sum += arr[start - moving];

                    start = start - moving;
                }
                else
                {
                    move = false;
                }

            }
            Console.WriteLine(sum);

        }
    }
}
