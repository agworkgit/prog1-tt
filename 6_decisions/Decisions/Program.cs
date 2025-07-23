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
        enum Browser // enumerations must be outside Main()
        {
            EDGE = 1, CHROME = 2, SAFARI = 3, FIREFOX = 4, VIVALDI = 5
        }
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
            int prompt;
            bool answer;

            Console.WriteLine("Q1. What's your favourite browser? >> ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("1 - Edge");
            Console.WriteLine("2 - Chrome");
            Console.WriteLine("3 - Safari");
            Console.WriteLine("4 - Firefox");
            Console.WriteLine("5 - Vivaldi");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please make your selection (1 to 4): ");
            prompt = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n"); // same as WriteLine

            favouriteBrowser = Convert.ToInt32(prompt);

            switch ((Browser)favouriteBrowser) // we're casting Browser (enum) to int
            {
                case Browser.EDGE:
                    Console.WriteLine("You chose Edge!");
                    break;
                case Browser.CHROME:
                    Console.WriteLine("You chose Chrome, the most popular browser.");
                    break;
                case Browser.SAFARI:
                    Console.WriteLine("You chose the best browser for Macs, Safari.");
                    break;
                case Browser.FIREFOX:
                    Console.WriteLine("You must like open source a lot, your choice is Firefox.");
                    break;
                case Browser.VIVALDI:
                    Console.WriteLine("Customisation and privacy is a must for you, you selected Vivaldi.");
                    break;
                default:
                    Console.WriteLine("You're favourite browser is {0}.", favouriteBrowser);
                    break;
            }

            // Using ternary
            answer = (Browser)favouriteBrowser == Browser.CHROME ? true : false;

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}