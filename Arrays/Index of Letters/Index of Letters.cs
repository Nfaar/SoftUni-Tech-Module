using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToArray();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{str[i]} -> {(int)str[i] - 97}");
            }
        }
    }
}
