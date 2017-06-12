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
            var products = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var quantities = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            var prices = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToArray();

            var command = Console.ReadLine();

            while (command != "done")
            {
                PrintProduct(command,products,quantities,prices);


                command = Console.ReadLine();
            }
        }

        private static void PrintProduct(string command,string[] products, long[] quantities, decimal[] prices)
        {
            var index = Array.IndexOf(products, command);

            Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");
        }
    }
}
