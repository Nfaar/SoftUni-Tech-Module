using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var leftSum = 0;
            var rightSum = 0;

            var txt = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                if (leftSum != rightSum)
                {
                    leftSum = 0;
                    rightSum = 0;
                }
                else
                {
                    txt = true;
                    Console.WriteLine(i);
                }
            }
            if (!txt)
            {
                Console.WriteLine("no");
            }


        }
    }
}
