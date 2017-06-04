using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            for (char i = (char)startIndex; i <= endIndex; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
