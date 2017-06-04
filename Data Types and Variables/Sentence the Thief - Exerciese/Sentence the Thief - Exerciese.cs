using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_the_Thief___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = long.Parse(Console.ReadLine());

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
            var closest = long.MinValue;

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
            var sentence = 1.0;
            if (closest < sbyte.MinValue)
            {
                sentence = Math.Ceiling(closest / -128.0);
            }
            else if (closest > sbyte.MaxValue)
            {
                sentence = Math.Ceiling(closest / 127.0);
            }
            if (sentence == 1 )
            {
                Console.WriteLine($"Prisoner with id {closest} is sentenced to 1 year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} years");
            }
        }
    }
}
