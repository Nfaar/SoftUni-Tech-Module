using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();


            int counter = 0;
            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = arr[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);



        }
    }
}
