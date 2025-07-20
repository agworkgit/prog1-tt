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

namespace Constants
{
    class Program
    {
        static void Main()
        {
            const float PI = 3.14F; // PI is always the same
            double circumference;
            double radius;
            Console.WriteLine("What is your radius?: ");
            radius = Convert.ToDouble(Console.ReadLine());
            circumference = 2 * PI * radius * radius;
            Console.WriteLine("Your circle's circumference is {0}", Convert.ToSingle(circumference));
        }
    }
}