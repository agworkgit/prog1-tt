using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class AssignmentApps
    {
        public static void Main()
        {
            // Program 1
            Console.WriteLine("Please enter a single character: ");
            char userInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your response was {0}", userInput);
            Console.WriteLine("----------------------------------------------");

            // Program 2
            string question = "Is 4 times 4 equal to 16?";
            Console.WriteLine(question);
            Console.WriteLine("Respond with T for TRUE or F for FALSE");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'T')
            {
                Console.WriteLine("Your are correct, the response is {0}", answer);
            }
            else
            {
                Console.WriteLine("You didn't input T/F or your response is FALSE", answer);
            }
            Console.WriteLine("----------------------------------------------");

            // Program 3
            Console.WriteLine("Area of a circle calculator.");
            Console.WriteLine("Please enter your radius: ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            decimal pi = 3.14M;
            decimal area = pi * radius * radius;
            Console.WriteLine("Your circle area is: {0}", area);
            Console.WriteLine("----------------------------------------------");

            // Program 4
            Console.WriteLine("Difference between wires calculator");
            Console.WriteLine("Please enter your current flowing: ");
            decimal currentFlowing = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your wire resistance: ");
            decimal resistanceOfWire = Convert.ToDecimal(Console.ReadLine());
            decimal potentialDifference = currentFlowing * resistanceOfWire;
            Console.WriteLine("Your potential difference is {0}", potentialDifference);
            Console.WriteLine("----------------------------------------------");

            // Program 5
            Console.WriteLine("How many adult tickets do you need?");
            int adultTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many child tickets do you need?");
            int childTickets = Convert.ToInt32(Console.ReadLine());
            decimal adultTicketsCost = adultTickets * 3.75M;
            decimal childTicketsCost = childTickets * 2.25M;
            decimal totalCost = adultTicketsCost + childTicketsCost;
            Console.WriteLine("Your purchased {0} adult tickets and {1} child tickets, the total for the adult tickets is {2:C}, and the total cost for the child tickets is {3:C}, your total cost is {4:C}", adultTickets, childTickets, adultTicketsCost, childTicketsCost, totalCost);
            Console.WriteLine("----------------------------------------------");
        }
    }
}