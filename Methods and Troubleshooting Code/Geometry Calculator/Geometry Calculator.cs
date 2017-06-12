using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{GetFigureArea(figureType, a, b):f2}");
            ;
        }

        private static double GetFigureArea(string figureType, double a, double b)
        {
            double area = 0.0;
            if (figureType == "triangle")
            {
                area = a * b / 2;
            }
            else if (figureType == "square")
            {
                area = a * a;
            }
            else if (figureType == "rectangle")
            {
                area = a * b;
            }
            else if (figureType == "circle")
            {
                area = Math.PI * a * a;
            }
            return area;
        }
    }
}
