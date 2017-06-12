using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            var command = Console.ReadLine();

            while (command != "END")
            {

                if (command == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (command.Contains("Replace"))
                {
                    try
                    {
                        var newCommand = command.Split(' ').ToArray();
                        var index = int.Parse(newCommand[1]);
                        var replaceString = newCommand[2];
                        arr[index] = replaceString;


                        arr = arr.Select(s => s.Replace(arr[index], replaceString)).ToArray();


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                  
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",arr));
        }


    }
}
