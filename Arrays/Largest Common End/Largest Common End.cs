using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var minLen = Math.Min(firstArray.Length, secondArray.Length);

            var fromLeft = 0;
            var fromRight = 0;

            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    fromLeft++;
                }
            }
            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    fromRight++;
                }
            }
            Console.WriteLine(Math.Max(fromLeft,fromRight));
        }
    }
}
