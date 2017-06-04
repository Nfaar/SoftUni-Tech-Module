using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = char.Parse(Console.ReadLine());
            var evenOrOdd = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var type = 0;
            if (evenOrOdd == "odd")
            {
                type = 1;
            }

            string print = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                var items = Console.ReadLine();
                if (i % 2 == type)
                {
                    print += $"{items}{character}";
                }

            }
            Console.WriteLine(print.Remove(print.Length - 1));
        }
    }
}
