using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstPoint = GetLinePoint(x1, y1);
            var secondPoint = GetLinePoint(x2, y2);

            var thirdPoint = GetLinePoint(x3, y3);
            var fourthPoint = GetLinePoint(x4, y4);

            var longerFirst = string.Empty;
            var longerSecond = string.Empty;

            if (firstPoint > secondPoint)
            {
                longerFirst = $"({x1}, {y1})";
            }
            else
            {
                longerFirst = $"({x2}, {y2})";
            }
            if (thirdPoint > fourthPoint)
            {
                longerSecond = $"({x3}, {y3})";
            }
            else
            {
                longerSecond = $"({x4}, {y4})";
            }

            if (longerFirst == longerSecond)
            {
                Console.WriteLine(longerSecond);
            }
            else
            {
                Console.WriteLine($"{longerFirst}{longerSecond}");
            }

        }

        private static double GetLinePoint(double x, double y)
        {
            double point = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return point;
        }
        private static double GetLineLength()
    }
}

