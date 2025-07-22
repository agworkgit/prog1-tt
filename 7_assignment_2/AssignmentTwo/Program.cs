using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program
    {
        static void Main()
        {
            // Program 1
            Console.WriteLine("Program 1");
            Console.Write("Please input your message: ");
            string userMessage = Console.ReadLine();
            int messageLength = userMessage.Length;

            if (messageLength < 140)
            {
                Console.WriteLine("Your message is \'{0}\', and it's made up of {1} characters", userMessage, messageLength);
            }
            else
            {
                Console.WriteLine("Your message should be under 140 characters");
            }
            Console.WriteLine("");

            // Program 2
            Console.WriteLine("Program 2");
            Console.Write("Please enter you grade point average: ");
            double gradeAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your admission test score: ");
            double admissionTestScore = Convert.ToDouble(Console.ReadLine());

            if (gradeAverage >= 3.0 && admissionTestScore >= 60)
            {
                Console.WriteLine("You have been accepted!");
            }
            else if (gradeAverage < 3.0 && admissionTestScore >= 80)
            {
                Console.WriteLine("You have been accepted!");
            }
            else
            {
                Console.WriteLine("Rejected!");
            }
            Console.WriteLine("");

            // Program 3
            Console.WriteLine("Program 3");
            Console.Write("What is your hourly pay rate?: ");
            double hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the number of hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            double grossPay = hoursWorked * hourlyPayRate;

            if (grossPay >= 300.00)
            {
                grossPay -= grossPay * 0.1;
            }
            else if (grossPay > 300.00)
            {
                grossPay -= grossPay * 0.12;
            }

            Console.WriteLine("Your pay rate is {0}, and you worked {1} hours, meaning your net pay or take home pay is {2:C}", hourlyPayRate, hoursWorked, grossPay);
            Console.WriteLine("");

            // Program 4
            Console.WriteLine("Program 4");
            Console.Write("What is the length of your lawn in feet?: ");
            int lawnLengthFeet = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the width of your lawn in feet?: ");
            int lawnWidthFeet = Convert.ToInt32(Console.ReadLine());
            int userSquareFeet = lawnLengthFeet * lawnWidthFeet;

            int mowingSeasonWeeks = 20;
            int weeklyMowingFee = 0;

            if (userSquareFeet <= 0)
            {
                Console.WriteLine("Invalid input: Lawn size must be greater than 0!");
            }
            else if (userSquareFeet < 400)
            {
                weeklyMowingFee += 25;
            }
            else if ((userSquareFeet >= 400) && (userSquareFeet < 600))
            {
                weeklyMowingFee += 35;
            }
            else
            {
                weeklyMowingFee += 50;
            }

            Console.WriteLine("The weekly mowing fee is {0:C} and your total for the 20-week season is {1:C}", weeklyMowingFee, weeklyMowingFee * mowingSeasonWeeks);
            Console.WriteLine("");

            // Program 5
            Console.WriteLine("Program 5");
            Console.Write("What is the length of your lawn in feet?: ");
            int lawnLengthFt = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the width of your lawn in feet?: ");
            int lawnWidthFt = Convert.ToInt32(Console.ReadLine());
            int userSqFeet = lawnLengthFt * lawnWidthFt;
            Console.Write("Would you like to pay (1) once, (2) twice, or (3) 20 times per season?: ");
            int paymentType = Convert.ToInt32((Console.ReadLine()));

            int mowSeasonWeeks = 20;
            int weeklyMowFee = 0;
            int serviceCharge = 0;

            if (paymentType <= 0 || userSqFeet <= 0)
            {
                Console.WriteLine("Invalid input: Must be greater than 0, options are 1, 2 or 3");
            }
            else if (userSqFeet < 400)
            {
                weeklyMowFee += 25;
                if (paymentType == 1)
                {
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments, meaning your total for the season is {2:C}", userSqFeet, paymentType, weeklyMowFee * mowSeasonWeeks / paymentType);
                }
                if (paymentType == 2)
                {
                    serviceCharge += 5;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge, 2 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge));
                }
                if (paymentType == 3)
                {
                    serviceCharge += 3;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks), 3 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks)));
                }
            }
            else if ((userSqFeet >= 400) && (userSqFeet < 600))
            {
                weeklyMowFee += 35;
                if (paymentType == 1)
                {
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments, meaning your total for the season is {2:C}", userSqFeet, paymentType, weeklyMowFee * mowSeasonWeeks / paymentType);
                }
                if (paymentType == 2)
                {
                    serviceCharge += 5;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge, 2 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge));
                }
                if (paymentType == 3)
                {
                    serviceCharge += 3;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks), 3 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks)));
                }
            }
            else
            {
                weeklyMowFee += 55;
                if (paymentType == 1)
                {
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments, meaning your total for the season is {2:C}", userSqFeet, paymentType, weeklyMowFee * mowSeasonWeeks / paymentType);
                }
                if (paymentType == 2)
                {
                    serviceCharge += 5;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge, 2 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + serviceCharge));
                }
                if (paymentType == 3)
                {
                    serviceCharge += 3;
                    Console.WriteLine("You need to mow {0} square ft of lawn, you selected to pay in {1} payments of {2:C}, meaning your total for the season is {3:C}", userSqFeet, paymentType, (weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks), 3 * ((weeklyMowFee * mowSeasonWeeks / paymentType) + (serviceCharge * mowSeasonWeeks)));
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}