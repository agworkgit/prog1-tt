using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 - Named constant
 * Often simply called a constant
 * An idetifier whose contents cannot change
 * Created using the keyword const
 
 - Programmers usually name constants using all uppercase letters in C#, inserting underscores for readability

 - Self-documenting statement
 * Easy to understand even without program comments
 */

/* 
 - Working with Enumerations
 * An enumeration is a set of constants represented by identifiers
 * Enumerations example named DayOfWeek:
 * enum DayOfWeek
 * {
 *      SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
 * }
 */

namespace Constants
{
    class Program
    {
        enum DayOfWeek : int
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        };

        const double HST = 0.13d;
        static void Main()
        {
            const double PI = Math.PI; // PI is always the same
            double circumference;
            double radius;
            Console.WriteLine("What is your radius?: ");
            radius = Convert.ToDouble(Console.ReadLine());
            circumference = 2 * PI * radius * radius;
            Console.WriteLine("Your circle's circumference is {0}", Math.Round(circumference));

            Console.WriteLine((int)DayOfWeek.SUNDAY); // cast as int

            // Conditional exercise

            Console.Write("What's your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 10)
            {
                Console.WriteLine("You're too young!");
            }
            else if (age <= 30)
            {
                Console.WriteLine("The world is your oyster!");
            }
            else
            {
                Console.WriteLine("You're getting old!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}