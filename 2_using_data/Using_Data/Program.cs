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
            - Implicit cast (sometimes we lose precision, better to do it explicitly)
                * Automatic transformation that occurs when a value is assigned to a type with higher precedence
                * Example: aDouble = anInt;
            - Explicit cast
                * Placing the desired result type in parentheses followed by the variable or constant to be cast
                * Example: anInt = (int)aDouble;
            */

            /* Using the char data type
            - char data type
                * Holds any single Unicode character
            - Place constant characters values within single quotations marks (e.g., 'A')
            - Escape sequence
                * Stores a pair of characters
                * Begins with a backslash
                * A pair of symbols represents a single character
            */

            /* Common escape sequences
            \' Single quotation mark
            \" Double quotation mark
            \\ Backslash
            \0 Null
            \a Alert
            \b Backspace
            \f Form feed
            \n New line
            \r Carriage return
            \t Horizontal tab
            \v Vertical tab
            */

            /* Using the string data type
            - string data type
                * Holds a series of characters
            - Values are expressed within double quotation marks
            - Comparing strings
                * Use == and !=
                * Use the Equals() method, Compare() method, and CompareTo() method
            - Use the Length property of a string to determine its length
                * Example:
                string aString = "How long is this string?"
                Console.WriteLine("{0} is {1} characters long", aString, aString.Length);
            - Use the Substring() method to extract a portion of a string from a starting point for a specific length
                * Example:
                string word = "water"
                word.Substring(0, 1) is "w"
                word.Substring(2, 3) is "ter"
                word.Substring(3, 4) produces an error message 
            */

            /* Defining Named Constants 
            - Named constant
                * Often simply called a constant
                * An idetifier whose contents cannot change
                * Created using the keyword const
            - Programmers usually name constants using the uppercase letters, inserting underscores for readability
            - Self-documenting statement
                * Easy to understand even without program comments
            */

            /* Working with Enumerations
            - An enumeration is a set of constants represented by identifiers
            - Enumeration example named DayOfWeek:
                enum DayOfWeek
                {
                    SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
                }
            - By default, enumeration values are integers
                * Can specify otherwise by including a colon and a type name after the enumeration name
            - The identifiers in an enumeration are often meant to hold consecutive values
                * When you don't supply values, they start at 0 and increment by 1
                * In the DayOfWeek enumeration, SUNDAY is 0, MONDAY is 1, and so on
            */

            /* Accepting Console Input
            - Interactive program
                * A program that allows user input
            - Console.ReadLine() method
                * Accepts user input from the keyboard
                * Accepts all of the characters entered by a user until the user presses Enter
                * Characters can be assigned to a string
                * Must use a conversion method to convert the input string to the proper type
            */

            /* Example of using ReadLine */

            const double TAX_RATE = 0.06;
            string itemPriceAsString;
            double itemPrice;
            double total;
            Console.Write("Enter the price of an item >> ");
            itemPriceAsString = Console.ReadLine();
            itemPrice = Convert.ToDouble(itemPriceAsString);
            total = itemPrice + (itemPrice * TAX_RATE);
            Console.WriteLine("With a tax rate of {0}, a {1} item " + "costs {2}.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));

            /* End */

            /* Another example of console input */

            int myValue = 20;
            Console.WriteLine("Enter any value: ");
            string newValue = Console.ReadLine();
            myValue += Convert.ToInt32(newValue);
            Console.WriteLine("You typed {0}, converted string is {1}", newValue, myValue);

            /* Selected Convert class methods
             * Method - Description
             * ToBoolean() - Converts to an equivalent Boolean value
             * ToByte() - Converts to an 8-bit unsigned integer
             * ToChar() - Converts to a Unicode character
             * ToDecimal() - Converts to a decimal number
             * ToDouble() - Converts to a double precision floating point
             * ToInt16() - Converts to a 16-bit signed integer (a short)
             * ToInt32() - Converts to a 32-bit signed integer (an int)
             * ToInt64() - Converts to a 64-bit signed integer (a long)
             * ToSByte() - Converts to an 8-bit signed integer
             * ToSingle() - Converts to a single precision floating point number
             * ToString() - Converts to its equivalent String representation
             * ToUInt16() - Converts to a 16-bit unsigned integer
             * ToUInt32() - Converts to a 32-bit unsigned integer
             * ToUInt64() - Converts to a 64-bit unsigned integer
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