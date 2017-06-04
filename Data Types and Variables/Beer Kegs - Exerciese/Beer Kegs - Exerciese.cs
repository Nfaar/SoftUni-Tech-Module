using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var biggest = string.Empty;
            decimal volume = 0.0m;
            var biggestVol = 0.0m;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                volume = (decimal)Math.PI * (radius * radius) * height;
                if (volume > biggestVol)
                {
                    biggestVol = volume;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
