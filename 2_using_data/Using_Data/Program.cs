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
            float myMoney = 1000.00F; // Storing a true decimal, suffix needed

            /* Different suffix notations for literal conversion:
            * Put F at the end to make the number a float
            * Put D at the end to make the number a double (default)
            * Put M after it to make it a decimal
            * E stands for exponent (scientific notation)
            */

            // Write - makes the statements go on the same line
            // WriteLine - writes the line then breaks to a new line
            // ReadKey - will wait for some input to exit
            Console.WriteLine("This is the current year - " + currentYear);
            Console.WriteLine("Last year was - " + lastYear);
            Console.Write("Your current balance is $");
            Console.WriteLine(someMoney);
            // Using placeholders inside a string to slot in a different value, also called 'string interpolation'
            Console.WriteLine("The money available is ${0}", myMoney);
            Console.WriteLine("{0, 10}", 4); // this will insert the specified number of the 'space' character before 4, essentially formatting our output
            Console.WriteLine("{0, -8}, {1, -8}", "Richard", "Lee"); // String formatting
            Console.WriteLine("{0, -8}, {1, -8}", "Marcia", "Parker"); // {0, -8} String field size (console output formatting)
            Console.WriteLine("Richard " + "Lee");

            /* Using Arithmetic Operators
            * + Addition
            * - Subtraction
            * * Multiplication
            * / Division
            * % Remainder (modulus/mod)
            */

            /* Using Shortcut Arithmetic Operators
            - Add and assign operators
            * Example : bankBal += bankBal * interestRate;
            * Variations : -=, *=, /=, and %=
            - Prefix increment operator
            * Example : ++someValue;
            - Suffix increment operator
            * Example : someValue++;
            - Unary operator
            * Uses only one value, example: -123
            - Decrement operator
            * Can be prefixed or suffixed to subtract 1 and show result
            */

            /* Using the bool data type
            - Boolean variable
            * Can hold only one of two values - true or false
            * Declare a Boolean variable with type bool
            - Comparison operator
            * Compares two items
            * An expression containing a comparison operator returns a Boolean value
            */

            /* Comparison operators
            * < Less than
            * > Greater than
            * == Equal to
            * <= Less than or equal to
            * >= Greater than or equal to
            * != Not equal to
            */

            // Example using a bool data type and a comparison operator

            int hoursWorked = 30;
            int threshold = 40;
            int hoursBalance = threshold - hoursWorked;
            bool employeeWorkedOvertime = hoursWorked > threshold;

            if (employeeWorkedOvertime)
            {
                // Executes if bool is true
                // Code to calculate overtime goes here
                Console.WriteLine("The employee worked: {0} hours in overtime", hoursBalance);
            }
            else
            {
                // Executes if bool is false, if missing the first block is skipped
                Console.WriteLine("The employee worked: {0} hours and didn't go overtime", hoursBalance);
            }

            // Bool result - FALSE
            // Final result - The employee worked: 10 hours and didn't go overtime

            // Working with floats below

            float myOtherMoney = 1000.00F;
            float yourMoney = 20.00F;
            myOtherMoney += 10.00F;
            myOtherMoney++; // Adds 1 to the current value
            // There exists also decrement (-1), example: myOtherMoney--

            float result = myOtherMoney + yourMoney;
            Console.WriteLine("Final result: {0:C2}", result); // 1031, C2 is currency formatting and 2 decimal places

            /* Understanding numberic type conversion 
            - Arithmetic with variables or constants of the same type
                * Result retains the same type
            - Arithmetic with operands of dissimilar types
                * C# chooses a unifying type for the result
                * Implicitly (or automatically) converts nonconforming operands to the unifying type
                    • Type with the higher type precedence
                * Not all conversions can be done implicitly
                    • For example, a double cannot be implicitly converted to an int
            */

            /* Understanding numberic type conversion (cont'd.)
            - Implicit cast
                * Automatic transformation that occurs when a value is assigned to a type with higher precedence
                * Example: aDouble = anInt;
            - Explicit cast
                * Placing the desired result type in parentheses followed by the variable or constant to be cast
                * Example: anInt = (int)aDouble;
            */
            
            Console.WriteLine("Press any key to EXIT...");
            Console.ReadKey();
        }
    }
}

// QUIZ 1

// 1. A - Variable (a named location in computer memory that can hold different values at different times)
// 2. D - Placeholder (consists of a pair of curly braces containing the number that indicates the desired variables's position - string interpolation)
// 3. B - bool (indicates Boolean variable type)
// 4. A - = is the C# assignment operator