/* 
 - using statements (abstract/in the background) load into our namespace built-in or external language libraries
 - can also be said to be import statements
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 - VALUE SUFFIXES REVIEW
 * Put an F after a number to make it a float (single point)
 * Put a D after it to make it a double (double precision)
 * Put an M after it to make it a decimal (scientific calc)
 * E is for exponent (scientific notation)
 */

// Think of namespace as a folder, there can be many namespaces (folders)
// Usually the project name
namespace Conditionals
{
    // Inside the namespace we find classes (a box for our program)
    class Program
    {
        // Class main method or function
        // The libraries imported at the top will be available here
        static void Main()
        {
            // Your code goes here from now until the end of the course

            // Practice code - Daily allowance calc in Euros (conditionals)

            Console.WriteLine("Daily allowance calculator");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Do you have some money? (Y/N): ");
            string init = Console.ReadLine();
            if (init == "Y")
            {
                Console.Write("What is your current month balance?: ");
                double prompt = Convert.ToDouble(Console.ReadLine());
                if (prompt <= 100)
                {
                    Console.WriteLine("Your said you have {0}, that means you need to make a minimum of 30.00/per day to sustain yourself, come back when your income is higher than 100.00 to calculate your daily allowance.", prompt);
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    double result = Convert.ToDouble(prompt) / 30;
                    string formattedCurrencyItaly = string.Format(new CultureInfo("it-IT"), "{0:C}", result);
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Your daily allowance is {0}", formattedCurrencyItaly);
                }
            }
            else
            {
                Console.WriteLine("Go make some money first then come back.");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}