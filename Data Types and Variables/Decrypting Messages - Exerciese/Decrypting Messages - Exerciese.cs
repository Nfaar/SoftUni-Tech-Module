using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Messages___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            string word = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                word += $"{(char)(input + key)}";
            }
            Console.WriteLine(word);
        }
    }
}
