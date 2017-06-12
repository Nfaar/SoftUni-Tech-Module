using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                GetNumsFromEvenArr(arr, arr.Length);
            }
            else if (arr.Length % 2 == 1)
            {
                GetNumsFromOddArr(arr, arr.Length);
            }
        }

        private static void GetNumsFromEvenArr(int[] arr, int n)
        {
            Console.WriteLine($"{arr[n/2-1]} {arr[n/2]}");
        }

        private static void GetNumsFromOddArr(int[] arr, int n)
        {
            Console.WriteLine($"{arr[n / 2 - 1]} {arr[n / 2]} {arr[n/2 + 1]}");
        }
    }
}
