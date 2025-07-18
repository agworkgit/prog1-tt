// Making first commit from VMWare Fusion Windows 11, Visual Studio 2022
// Visual Studio fully operational for the next class

// Importing Libraries
// Using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Main folder where the program is held
namespace COMP100_using_data
{
    // Container for all of our code
    class App
    {
        // The body of the class can contain multiple methods
        /* This our Main Method 
        * We place all our lines of code here
        */
        static void Main()
        {
            // The console class is a library of information, we use a dot to access other properties of the class
            int currentYear = 2025;
            int lastYear = currentYear - 1;
            double someMoney = 39.45;

            // Write - makes the statements go on the same line
            // WriteLine - writes the line then breaks to a new line
            // ReadKey - will wait for some input to exit
            Console.WriteLine("This is the current year - " + currentYear);
            Console.WriteLine("Last year was - " + lastYear);
            Console.Write("Your current balance is $");
            Console.WriteLine(someMoney);
            // Using placeholders inside a string to slot in a different value, also called 'string interpolation'
            Console.WriteLine("The money available is ${0}", someMoney);
            Console.WriteLine("{0, 10}", 4); // this will insert the specified number of the 'space' character before 4, essentially formatting our output
            Console.WriteLine("{0, -8}, {1, -8}", "Richard", "Lee"); // String formatting
            Console.WriteLine("{0, -8}, {1, -8}", "Marcia", "Parker"); // {0, -8} String field size (console output formatting)
            Console.WriteLine("Richard " + "Lee");
            Console.WriteLine("Press any key to EXIT...");
            Console.ReadKey();
        }
    }
}