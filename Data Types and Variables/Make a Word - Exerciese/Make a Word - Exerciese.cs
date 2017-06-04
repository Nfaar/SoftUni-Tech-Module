using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char a = char.Parse(Console.ReadLine());

                text += a;
            }

            Console.WriteLine($"The word is: {text}");
        }
    }
}
