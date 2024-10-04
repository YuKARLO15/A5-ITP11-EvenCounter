using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvenCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            init:
            try
            {
            start:
                Console.WriteLine("");
                Console.WriteLine("This program will find all even numbers in a given range.");
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Enter the first number: ");
                int min = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int max = Convert.ToInt16(Console.ReadLine());

                if (min > max)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The first number must be smaller than the second number");
                    goto start;
                }
                else
                {
                    Console.WriteLine("List of even numbers:");
                    for (int i = min; i <= max; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(" ");
                            Console.Write(i);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to try again?");
                    string confirm = (Console.ReadLine()).ToLower();
                    if (confirm == "y")
                    {
                        goto start;
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine(ex.ToString());
                goto init;
            }
        }
    }
}
