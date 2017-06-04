using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            bool text = bool.Parse((Console.ReadLine()));

            if (text)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
