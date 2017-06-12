using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_оf_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();


            Console.WriteLine(GetLastDigitName(num));


        }

        private static string GetLastDigitName(string num)
        {
            var name = string.Empty;

            if (num.EndsWith("0"))
            {
                name = "zero";
            }
            else if (num.EndsWith("1"))
            {
                name = "one";
            }
            else if (num.EndsWith("2"))
            {
                name = "two";
            }
            else if (num.EndsWith("3"))
            {
                name = "three";
            }
            else if (num.EndsWith("4"))
            {
                name = "four";
            }
            else if (num.EndsWith("5"))
            {
                name = "five";
            }
            else if (num.EndsWith("6"))
            {
                name = "six";
            }
            else if (num.EndsWith("7"))
            {
                name = "seven";
            }
            else if (num.EndsWith("8"))
            {
                name = "eight";
            }
            else if (num.EndsWith("9"))
            {
                name = "nine";
            }
            return name;
        }
    }
}
