using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());

            var secondBoatUpgradedChar = (int)secondBoat;
            var firstBoatUpgradedChar = (int) firstBoat;

            var sumFirstBoat = 0;
            var sumSecondBoat = 0;


            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var moves = Console.ReadLine();

                if (moves == "UPGRADE")
                {
                    firstBoatUpgradedChar += 3;
                    secondBoatUpgradedChar += 3;
                }
                if (i % 2 == 1)
                {
                    sumFirstBoat += moves.Length;
                }
                else if (i % 2 == 0)
                {
                    sumSecondBoat += moves.Length;
                }

                if (sumFirstBoat >= 50)
                {
                    Console.WriteLine((char)secondBoatUpgradedChar);
                    return;
                }
                if (sumSecondBoat >=50)
                {
                    Console.WriteLine((char)firstBoatUpgradedChar);
                    return;
                }

            }
            if (sumFirstBoat > sumSecondBoat)
            {

                Console.WriteLine((char)secondBoatUpgradedChar);
            }
            else
            {
                Console.WriteLine((char)firstBoatUpgradedChar);
            }
        }
    }
}
