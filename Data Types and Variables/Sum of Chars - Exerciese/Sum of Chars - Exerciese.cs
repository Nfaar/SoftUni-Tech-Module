using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                char characters = char.Parse(Console.ReadLine());

                sum += characters;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
