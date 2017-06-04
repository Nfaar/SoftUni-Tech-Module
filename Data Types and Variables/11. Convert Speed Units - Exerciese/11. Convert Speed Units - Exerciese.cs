using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var sumSec = hours * 3600 + minutes * 60 + seconds;


            float metersInSeconds = (float)distanceInMeters / sumSec;
            float kmInHours = (distanceInMeters / 1000f) / (sumSec / 3600f);
            float mileInHours = (distanceInMeters / 1609f) / (sumSec / 3600f);
            Console.WriteLine($"{metersInSeconds}\n{kmInHours}\n{mileInHours}");
        }
    }
}
