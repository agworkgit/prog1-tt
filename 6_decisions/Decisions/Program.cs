using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main()
        {
            int age;

            Console.Write("What is your age?: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 10)
            {
                Console.WriteLine("You're so young!");
            }
            else if (age > 10 && age < 20)
            {
                Console.WriteLine("Exciting age!");
            }
            else if (age > 20 && age < 30)
            {
                Console.WriteLine("The world is your oyster!");
            }
            else if (age > 30 && age < 40)
            {
                Console.WriteLine("You're not as pretty anymore!");
            }
            else if (age > 40)
            {
                Console.WriteLine("You're getting old!");
            }
            else
            {
                Console.WriteLine("Error - Invalid input!");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            /* if (prompt == 0)
                {
                    Console.WriteLine("Error - Invalid input, only numbers above 0 are accepted!");
                }
                else
                {
                    if (prompt < 30)
                    {
                        if (prompt <= 10)
                        {
                            Console.WriteLine("You're too young!");
                        }
                        else
                        {
                            Console.WriteLine("The world is your oyster!");
                        }
                    }
                    else if (prompt >= 30)
                    {
                        if (prompt >= 40)
                        {
                            Console.WriteLine("You're getting old!");
                        }
                        else
                        {
                            Console.WriteLine("You're not as pretty as you used to be.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error - Invalid input, only numbers above 0 are accepted!");
                    }
                } */

            // Switch Statement example
            int favouriteBrowser;
            string prompt;

            Console.WriteLine("Q1. What's your favourite browser? >> ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1 - Edge");
            Console.WriteLine("2 - Chrome");
            Console.WriteLine("3 - Safari");
            Console.WriteLine("4 - Firefox");
            Console.WriteLine("5 - Vivaldi");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please make your selection (1 to 4): ");
            prompt = Console.ReadLine();
            Console.Write("\n"); // same as WriteLine

            favouriteBrowser = Convert.ToInt32(prompt);

            switch (favouriteBrowser)
            {
                case 1:
                    Console.WriteLine("You chose Edge!");
                    break;
                case 2:
                    Console.WriteLine("You chose Chrome, the most popular browser.");
                    break;
                case 3:
                    Console.WriteLine("You chose the best browser for Macs, Safari.");
                    break;
                case 4:
                    Console.WriteLine("You must like open source a lot, your choice is Firefox.");
                    break;
                case 5:
                    Console.WriteLine("Customisation and privacy is a must for you, you selected Vivaldi.");
                    break;
                default:
                    Console.WriteLine("You're favourite browser is {0}.", favouriteBrowser);
                    break;
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}