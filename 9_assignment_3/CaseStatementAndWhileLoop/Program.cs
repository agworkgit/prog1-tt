using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseWhile
{
    class Program
    {
        static void Main()
        {
            // If the user selects one or two, keep repeating, if they select 3 exit the program

            Console.Write("Would you like (1) a pizza, (2) a burger or (3) to exit?: ");
            int prompt = Convert.ToInt32(Console.ReadLine());

            while (prompt != 3)
            {
                switch (prompt)
                {
                    case 1:
                        Console.Write("You're eating a pizza, press a key to return to main menu...");
                        Console.ReadKey();
                        Console.WriteLine("Would you like (1) a pizza, (2) a burger or (3) to exit?: ");
                        prompt = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("You're eating a burger, press a key to return to main menu...");
                        Console.ReadKey();
                        Console.WriteLine("Would you like (1) a pizza, (2) a burger or (3) to exit?: ");
                        prompt = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("You chose to exit.");
                        break;
                    default:
                        Console.Write("Error! Please select (1), (2) or (3): ");
                        prompt = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit console...");
            Console.ReadKey();
        }
    }
}