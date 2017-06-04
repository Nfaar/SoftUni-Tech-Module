using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num,16).ToUpper());
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
