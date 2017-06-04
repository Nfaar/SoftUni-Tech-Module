using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());

                if (n >= -128 && n <= 127)
                {
                    Console.WriteLine("Sunny");
                }
                else if (n >= int.MinValue && n <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch
            {
                Console.WriteLine("Rainy");
            }

            
        }
    }
}
