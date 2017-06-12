using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var daysOfWeek = new string[] {"Monday","Tuesday","Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            try
            {
                Console.WriteLine(daysOfWeek[n - 1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
