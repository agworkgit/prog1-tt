using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Looping
{
    class Program
    {
        static void Main()
        {
            // Example 1
            int number = 1;
            const int LIMIT = 5; // constant convention is to CAPITALISE
            while (number < LIMIT)
            {
                Console.WriteLine("Hello");
                number = number + 1; // increases number until the while condition is FALSE
            }

            // Example 2
            int count = 0; // sentinel variable (the initialiser)
            while (count <= 30) // condition to check
            // repetition block below
            {
                Console.WriteLine("Playing Count: {0}", count);
                count++; // increment count by 1, same as count += 1, same as count = count + 1
                /*                 if (count > 30) // stop condition not needed
                                {
                                    gameLoop = false;
                                } */
            }

            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }
    }
}