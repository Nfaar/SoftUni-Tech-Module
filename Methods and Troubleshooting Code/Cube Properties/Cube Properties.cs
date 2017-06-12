using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();

            Console.WriteLine($"{GetCubeArea(n, parameter):f2}");
        }

        private static double GetCubeArea(double n, string parameter)
        {
            double area = 0.0;
            if (parameter == "face")
            {
                area = Math.Sqrt(2 * Math.Pow(n, 2));
            }
            else if (parameter == "space")
            {
                area = Math.Sqrt(3 * Math.Pow(n, 2));
            }
            else if (parameter == "volume")
            {
                area = Math.Pow(n, 3);
            }
            else if (parameter == "area")
            {
                area = 6 * Math.Pow(n, 2);
            }
            return area;
        }
    }
}
