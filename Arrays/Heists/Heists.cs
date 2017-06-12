using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            var priceOfGoldAndJewels = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            long priceOfJewels = priceOfGoldAndJewels[0];
            long priceOfGold = priceOfGoldAndJewels[1];

            long earnings = 0;
            long expenses = 0;

            var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Jail")
            {
                var text = command[0];
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '%')
                    {
                        earnings += priceOfJewels;
                    }
                    if (text[i] == '$')
                    {
                        earnings += priceOfGold;
                    }
                }
                expenses += int.Parse(command[1]);


                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            var diff = earnings - expenses;

            if (diff >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(diff)}.");
            }

        }
    }
}
