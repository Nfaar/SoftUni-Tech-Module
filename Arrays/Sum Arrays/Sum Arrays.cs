using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var max = Math.Max(firstArray.Length, secondArray.Length);

            var sumArray = new int[max];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];

            }

            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
