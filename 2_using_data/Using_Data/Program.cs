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
            
            Console.WriteLine("This is the current year - " + currentYear);
            Console.WriteLine("Last year was - " + lastYear);
            Console.WriteLine("Press any key to EXIT...");
            Console.ReadKey();
        }
    }
}