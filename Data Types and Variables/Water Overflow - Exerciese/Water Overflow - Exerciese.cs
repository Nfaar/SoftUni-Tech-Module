using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sumLiquid = 0;

            for (int i = 0; i < n; i++)
            {
                var pour = int.Parse(Console.ReadLine());
                if (sumLiquid + pour > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumLiquid += pour;
                }
            }
            Console.WriteLine(sumLiquid);
        }
    }
}
