using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < array.Length -1; i++)
            {
                
                for (int j = i+1; j < array.Length; j++)
                {
                    var sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        found = true;
                        
                    }
                    
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }

        }
    }
}
