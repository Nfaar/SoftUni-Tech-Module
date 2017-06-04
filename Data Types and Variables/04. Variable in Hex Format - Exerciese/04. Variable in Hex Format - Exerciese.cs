using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexa = Console.ReadLine();
            var toInt = Convert.ToInt32(hexa, 16);
            Console.WriteLine(toInt);
        }
    }
}
