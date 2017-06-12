using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            var secondArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            if (firstArr.Length > secondArr.Length)
            {
                PrintArr(secondArr);
                PrintArr(firstArr);

            }
            else if (firstArr.Length < secondArr.Length)
            {
                PrintArr(firstArr);
                PrintArr(secondArr);
            }
            else if (firstArr.Length == secondArr.Length)
            {
                GetBiggerString(firstArr, secondArr);
            }

        }

        private static void PrintArr(char[] arr)
        {
            Console.WriteLine(string.Join("", arr));
        }


        private static void GetBiggerString(char[] firstArr, char[] secondArr)
        {
            var bigger = string.Empty;
            var smaller = string.Empty;

            var found = true;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    bigger = string.Join("", firstArr);
                    smaller = string.Join("", secondArr);
                    found = false;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    bigger = string.Join("", secondArr);
                    smaller = string.Join("", firstArr);
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine(bigger);
                Console.WriteLine(smaller);
            }
            else
            {
                Console.WriteLine(string.Join("",firstArr));
                Console.WriteLine(string.Join("", firstArr));
            }
        }
    }
}
