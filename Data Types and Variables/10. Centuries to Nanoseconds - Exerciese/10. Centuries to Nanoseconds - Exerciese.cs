using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = 24 * days;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            decimal miliSeconds = seconds * 1000m;
            decimal microSeconds = miliSeconds * 1000m;
            decimal nanoSeconds = microSeconds * 1000m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
