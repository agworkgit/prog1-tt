// IDE - Integrated Development Environment (reads/writes code)
// Compiler - Compiles the code down to executable machine code
// Namespace - Acts as a container, groups similar classes, can be used to avoid naming conflicts in larger projects
// Access Modifier - Defines the circumstances under which the method can be accessed: public, private, protected, internal

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
    // - Encapsulation (hidden information / black box - the engineering details)
    // - Interfaces (passing messages to request or receive information)
    // - Inheritance (inheriting an object and adding to it)
    // - Polymorphism (inheriting and morphing the class properties)
    class Application
    {
        // This is called a main method (or function), here's our starting place for our code
        // In this case, Main() is the method HEADER which defines what the method does
        static void Main()
        {
            // Lines of code inside a codeblock, also called the method BODY
            int myInteger = 0;
            string myString = "I also wrote my first string";
            System.Console.WriteLine("The int variable value is " + myInteger + ", " + myString);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); // waits for a key to be pressed
        }
    }
}