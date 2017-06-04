using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());


            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            var c = a;
            a = b;
            b = c;

            Console.WriteLine($"After:\na = {a}\nb = {b}");

        }
    }
}
