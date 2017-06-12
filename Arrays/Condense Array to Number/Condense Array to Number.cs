using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


          
            var sum = 0;
            while (arr.Length > 1)
            {
                var condensed = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];


                }
                arr = condensed;
            }
            Console.WriteLine(arr[0]);

        }
    }
}
