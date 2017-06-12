using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var quantities = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            var prices = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToArray();

            var command = Console.ReadLine().Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "done")
            {
                PrintProduct(command, products, quantities, prices);


                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void PrintProduct(string[] command, string[] products, long[] quantities, decimal[] prices)
        {
            var index = Array.IndexOf(products, command[0]);

            var quantitiOfProduct = long.Parse(command[1]);


            bool found = true;


            if (index > quantities.Length - 1)
            {
                Console.WriteLine($"We do not have enough {products[index]}");
            }
            else
            {
                var quantitiesLeft = quantities[index];

                if (quantitiesLeft - quantitiOfProduct >= 0)
                {
                    quantities[index] -= quantitiOfProduct;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                    found = false;
                }

                if (quantities[index] < 0)
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                else
                {
                    if (found)
                    {
                        Console.WriteLine($"{products[index]} x {quantitiOfProduct} costs {quantitiOfProduct * prices[index]:f2}");
                    }

                }

            }




        }
    }
}
