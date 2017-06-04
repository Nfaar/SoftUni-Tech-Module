using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_the_Thief___Exerciese
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = long.Parse(Console.ReadLine());

            var closest = long.MinValue;

            long typeMaxValue = 0;
            if (type == "sbyte")
            {
                typeMaxValue = sbyte.MaxValue;
            }
            else if (type == "int")
            {
                typeMaxValue = int.MaxValue;
            }
            else if (type == "long")
            {
                typeMaxValue = long.MaxValue;
            }


            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());
                if (id <= typeMaxValue)
                {
                    if (id > closest)
                    {
                        closest = id;
                    }
                }
            }
            Console.WriteLine(closest);

        }
    }
}
