/* 
 - using statements (abstract/in the background) load into our namespace built-in or external language libraries
 - can also be said to be import statements
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.Write("Insert a string to be character counted: ");

            string origString = Console.ReadLine();
            int countThis = origString.Length;

            Console.WriteLine("The string \"{0}\", has {1} characters", origString, countThis);
        }
    }
}