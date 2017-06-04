using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTypeOfUnit(unit, value));
        }

        private static string  GetTypeOfUnit(string unit, double value)
        {
            var output = string.Empty;
            if (unit == "miles")
            {
                output = $"{value} {unit} = {value * 1.6:f2} kilometers";
            }
            else if (unit == "inches")
            {
                output = $"{value} {unit} = {value * 2.54:f2} centimeters";
            }
            else if (unit == "feet")
            {
                output = $"{value} {unit} = {value * 30:f2} centimeters";
            }
            else if (unit == "yards")
            {
                output = $"{value} {unit} = {value * 0.91:f2} meters";
            }
            else if (unit == "gallons")
            {
                output = $"{value} {unit} = {value * 3.8:f2} liters";
            }

            return output;
        }
    }
}
