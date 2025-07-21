using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main()
        {
            int prompt;

            Console.Write("What is your age?: ");
            prompt = Convert.ToInt32(Console.ReadLine());

            if (prompt == 0)
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
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}