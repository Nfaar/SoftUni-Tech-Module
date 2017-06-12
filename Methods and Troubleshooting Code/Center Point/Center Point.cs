using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var firstPoint = GetFirstPoint(x1, y1);
            var secondPoint = GetSecondPoint(x2,y2);

            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }

        private static double GetFirstPoint(double x1, double y1)
        {
            var point = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            return point;
        }
        private static double GetSecondPoint(double x2, double y2)
        {
            var point = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            return point;
        }

    }
}
