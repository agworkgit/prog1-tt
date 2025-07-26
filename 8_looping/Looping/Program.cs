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

            int number = 1;
            const int LIMIT = 5; // constant convention is to CAPITALISE
            while (number < LIMIT)
            {
                Console.WriteLine("Hello");
                number = number + 1; // increases number until the while condition is FALSE
            }
        }
    }
}