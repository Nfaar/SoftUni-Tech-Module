using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var roundedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }
        }
    }
}
