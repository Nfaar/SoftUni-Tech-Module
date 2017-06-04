using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer___Exerciese
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var ft = long.Parse(Console.ReadLine());
            var ff = long.Parse(Console.ReadLine());
            var ut = long.Parse(Console.ReadLine());


            var filteredPictures = Math.Ceiling(n * (ff / 100m));

            long allFiltered = n * ft;
            long filteredUpload = (long)filteredPictures * ut;

            long totalTime = allFiltered + filteredUpload;

            var convertTime = TimeSpan.FromSeconds(totalTime);

            string str = convertTime.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(str);

        }
    }
}
