using System;
using System.ComponentModel.Design.Serialization;

namespace Do_Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();

            int selection = 0; // initialise

            do // executes once then checks the condition (works better for menus)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("- 1. First Choice                     -");
                Console.WriteLine("- 2. Second Choice                    -");
                Console.WriteLine("- 3. Exit                             -");
                Console.WriteLine("---------------------------------------");
                Console.Write("Please make your selection: ");
                selection = Convert.ToInt32(Console.ReadLine()); // get data from console input
                Console.WriteLine("---------------------------------------");

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("You chose 1.");
                        break;
                    case 2:
                        Console.WriteLine("You chose 2.");
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Incorrect entry - Try again!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press a key to exit...");
                Console.ReadKey();
                Console.Clear();
            } while (selection != 3);
        }
    }
}