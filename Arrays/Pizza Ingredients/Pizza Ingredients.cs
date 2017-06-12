using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var len = int.Parse(Console.ReadLine());

            var cnt = 0;

            var ingredientsInPizza = string.Empty;

            var moreThanTen = false;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == len)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    ingredientsInPizza += $"{ingredients[i]}, ";
                    cnt++;
                }
                if (cnt >= 10)
                {
                    Console.WriteLine($"Made pizza with total of 10 ingredients.");
                    Console.WriteLine($"The ingredients are: {ingredientsInPizza.Trim().Remove(ingredientsInPizza.Length - 2)}.");
                    return;
                }

            }

            Console.WriteLine($"Made pizza with total of {cnt} ingredients.");
            Console.WriteLine($"The ingredients are: {ingredientsInPizza.Trim().Remove(ingredientsInPizza.Length - 2)}.");

        }
    }
}
