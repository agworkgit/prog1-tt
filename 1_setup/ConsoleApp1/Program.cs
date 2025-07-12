// External libraries part of the language to be included at compile time
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp100_Lesson3
{
    // The class can be interpreted as a blueprint (an abstracted way of generating objects)
    // For a language to be considered object oriented, it must support the following features:
    // - Classes
    // - Objects
    // - Encapsulation (hidden information) and Interfaces
    // - Inheritance (inheriting an object and adding to it)
    // - Polymorphism
    class Program
    {
        // This is called a main method (or function), here's our starting place for our code
        static void Main()
        {
            // Lines of code inside a codeblock
            int myInteger = 0;
            string myString = "I also wrote my first string";
            Console.WriteLine("The int variable value is " + myInteger + ", " + myString);
        }
    }
}