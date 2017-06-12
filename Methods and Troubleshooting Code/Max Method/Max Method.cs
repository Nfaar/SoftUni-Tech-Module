using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var maxInt = GetMaxNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(maxInt);
        }

        private static int GetMaxNum(int firstNum, int secondNum, int thirdNum)
        {
            var firstTwo = Math.Max(firstNum, secondNum);
            var maxInt = Math.Max(firstTwo, thirdNum);
            return maxInt;

        }
    }
}
