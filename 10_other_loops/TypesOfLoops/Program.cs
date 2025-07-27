using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfLoops
{
    class Program
    {
        static void Main() // no args
        {
            int prompt = 0;  // control variable

            // create menu in here
            while (prompt != 3) // loop condition, below is the looping block
            {
                Console.WriteLine("=================================");
                Console.WriteLine("* 1. Say Hello                  *");
                Console.WriteLine("* 2. Say Goodbye                *");
                Console.WriteLine("* 3. EXIT PROGRAM               *");
                Console.WriteLine("=================================");
                Console.Write("Please choose an option above (1 - 3) >> ");

                prompt = Convert.ToInt32(Console.ReadLine());

                switch (prompt)
                {
                    // problem - we have too many repeating lines
                    case 1:
                        Console.WriteLine("Hello!");
                        Console.Write("\n"); // same as an empty WriteLine
                        Console.WriteLine("=================================");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear(); // clears the screen
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        Console.Write("\n"); // same as an empty WriteLine
                        Console.WriteLine("=================================");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear(); // clears the screen
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Error! Please select a valid option...");
                        Console.Write("\n"); // same as an empty WriteLine
                        Console.WriteLine("=================================");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear(); // clears the screen
                        break;
                }
            }

            Console.Write("\n"); // same as an empty WriteLine
            Console.WriteLine("=================================");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}