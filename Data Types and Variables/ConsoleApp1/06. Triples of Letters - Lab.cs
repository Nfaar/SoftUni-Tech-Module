using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char letter = (char)('a' + n);

            for (char i = 'a'; i < letter; i++)
            {
                for (char y = 'a'; y < letter; y++)
                {
                    for (char r = 'a'; r < letter; r++)
                    {
                        Console.WriteLine($"{i}{y}{r}");
                        
                    }
                }
            }
        }
    }
}
