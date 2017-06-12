using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                var num = int.Parse(Console.ReadLine());
                array[i] = num;

            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
