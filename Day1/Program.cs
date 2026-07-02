using System.Xml.Linq;

namespace Day1
{
    internal class Program
    {
        static void Main()
        {
            // Task 1 - Personal Info Card
            /*
            Console.WriteLine("Enter your name :");
            Console.WriteLine("Enter your age: ");
            Console.WriteLine("Enter your height: ");

            String userName = Console.ReadLine();
            int userAge = int.Parse(Console.ReadLine());
            float userHeight = float.Parse(Console.ReadLine());
            bool student = userAge >= 6 && userAge <= 23;

            Console.Write("Name:" + userName);
            Console.Write(" Age:" + userAge);
            Console.Write(" Height:" + userHeight);
            Console.Write(" Student:" + student);
            */
            ////////////////////////////////////////////////////////////////////////////

            // Task 2 - Rectangle Calculator
            /*
            Console.WriteLine("Enter the length of the rectangle:");
            Console.WriteLine("Enter the width of the rectangle:");
            float lenght = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float Area = lenght * width;
            float Perimeter = 2 * (lenght + width);

            Console.WriteLine("Area of rectangle:" + Area);
            Console.WriteLine("Perimeter of rectangle:" + Perimeter);
            */

            ////////////////////////////////////////////////////////////////////////////

            // Task 3 - Even or Odd Checker
            /*
            Console.WriteLine("Enter a number:");
            float number = float.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            */
            ///////////////////////////////////////////////////////////////////////////

            //Task 4 - Voting Eligibility
            /*
            Console.WriteLine("Enter your age:");
            Console.WriteLine("Do you have a valid ID? (yes/no):");
            int age = int.Parse(Console.ReadLine());
            String ValidId = Console.ReadLine().ToLower();
            bool CheckId = ValidId == "yes"; 

            if (age >= 18 && CheckId)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            */
            ////////////////////////////////////////////////////////////////////////////

            //Task 5 - Grade Letter Lookup
            /*
            Console.WriteLine("From the grades shown below: ");
            Console.Write("A ,");
            Console.Write("B ,");
            Console.Write("C ,");
            Console.Write("D ,");
            Console.WriteLine("F ");
            Console.Write("Enter your grade: ");


            String grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.Write("Excellent");
                    break;

                case "B":
                    Console.Write(" Very Good");
                    break;
                case "C":
                    Console.Write(" Good");
                    break;
                case "D":
                    Console.Write("Pass");
                    break;
                case "F":
                    Console.Write("Fail");
                    break;
            */
            ////////////////////////////////////////////////////////////////////////////

            //Task 6 - Temperature Converter
            /*
            Console.Write("Enter the temperatute in Celsius: ");
            float Celsius = float.Parse(Console.ReadLine());
            
            if (Celsius < 10)
            {
                Console.WriteLine("The weather is Cold");
            }
            else if (Celsius > 10 && Celsius < 30)
            {
                Console.WriteLine("The weather is Mild");
            }
            else
            {
                Console.WriteLine("The weather is Hot");
            }
            
            double Fahrenheit = (Celsius * 9 / 5) + 32; 
            Console.WriteLine("The temparature in Fahrenheit is " + Fahrenheit);
            */
            ///////////////////////////////////////////////////////////////////////////

            //Task 7 - Movie Ticket Pricing
            /*
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Ticket price for children (0-12 years) is  2.000 OMR");
            }
            else if (age >= 13 && age <= 59)
            {
                Console.WriteLine("Ticket price for adults (13-59 years) is 5.000 OMR");

            }
            else if (age >= 60)
            {
                Console.WriteLine("Ticket price for seniors (60+ years) is 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");

            }
            */
            //////////////////////////////////////////////////////////////////////////////

            //Task 8 - Restaurant Bill with Membership Discount
            /*
            Console.WriteLine("Enter the total bill amount:");
            float totalbill = float.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a loyalty card? (yes/no):");
            String card = Console.ReadLine().ToLower();
            bool loyaltycard = card == "yes";
            if (totalbill > 20 && loyaltycard)

            {
                Console.WriteLine("You are eligible for a 15% discount.");
                double discount = totalbill - (totalbill * 0.15);
                Console.WriteLine("Your total bill after discount is: " + discount + " OMR");
            }
            else
            {
                Console.WriteLine("You are not eligible for a discount.");
                Console.WriteLine("Your total bill is: " + totalbill + " OMR");
            }
            */
            //////////////////////////////////////////////////////////////////////////////

            //Task 9 - Day Name Finder
            /*
            Console.WriteLine("Enter a number (1-7) to find the corresponding day of the week:");
            int dayNumber = int.Parse(Console.ReadLine());

            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is Sunday.");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday.");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday.");
                    break;
                case 6:
                    Console.WriteLine("The day is Friday.");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
            */
            //////////////////////////////////////////////////////////////////////////////

            //Task 10 - Mini Calculator
            /*
            Console.WriteLine("Enter the first number:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation (+, -, *, /, %):");
            char operation = char.Parse(Console.ReadLine());

            switch(operation)
            {
                case '+':
                    Console.WriteLine("Result: " + (firstNumber + secondNumber));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (firstNumber - secondNumber));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (firstNumber * secondNumber));
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        Console.WriteLine("Result: " + (firstNumber / secondNumber));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                case '%':
                    if (secondNumber != 0)
                    {
                        Console.WriteLine("Result: " + (firstNumber % secondNumber));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break; 
            }
            */
            //////////////////////////////////////////////////////////////////////////////

           // Task 11 - Loan Eligibility System
           Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your monthly income (OMR): ");
            float income = float.Parse(Console.ReadLine());
            Console.WriteLine("Do you have any existing loans? (yes/no): ");
            String loans = Console.ReadLine().ToLower();
            bool ExistingLoans = loans == "yes";
            if (age > 21 && age < 60 && income >= 400 && !ExistingLoans)
            {
                Console.WriteLine("You are eligible for a loan.");
            }
            else if (age <= 21 || age >= 60)
            {
                Console.WriteLine("Not eligible for a loan (age out of range)");
            }
            else if (income < 400)
            {
                Console.WriteLine("Not eligible for a loan (income too low)");
            }
            else if (ExistingLoans)
            {
                Console.WriteLine("Not eligible for a loan (has an existing loan)");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


    }

        
}
