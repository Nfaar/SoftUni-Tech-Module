using System;
using System.Data;

namespace _16.Comparing_floats___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            double diff = 0.000001;

            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            if (Math.Max(absA,absB) - Math.Min(absA,absB) < diff)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
