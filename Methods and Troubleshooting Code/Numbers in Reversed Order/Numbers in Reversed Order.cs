using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine($"{ReverseNumber(num)}");



        }
        static double ReverseNumber(double number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
