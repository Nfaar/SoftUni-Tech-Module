using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintGreeting(name);
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
