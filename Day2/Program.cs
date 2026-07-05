using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer
            /*
            Console.WriteLine("Enter a starting number: ");
            int startingNumber = int.Parse(Console.ReadLine()); 
            int counter = 0;
            for (counter = startingNumber; counter >= 1; counter --) 

            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Liftoff!");
            */
            /////////////////////////////////////////////////////////////////////
            //Task 2 - Sum of Numbers 1 to N
            /*
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter;
            for (counter = 1; counter <= number; counter++)
            {
                sum = sum + counter;
            }

            Console.WriteLine("The final sum is: " + sum); 
            */
            /////////////////////////////////////////////////////////////////////
            //Task 3 - Multiplication Table
            /*
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int counter;
            int multiplication = 0;
            for (counter = 1; counter <= 10; counter++)
            {
                multiplication = number * counter;
                Console.WriteLine(number + " x " + counter + " = " + multiplication);
            }
            */
            /////////////////////////////////////////////////////////////////////
            ///Task 4 - Password Retry
            /*
            Console.WriteLine("Enter your password: ");
            String password = "Spark2026";
            String input = Console.ReadLine();

            while (input != password) 
            {
                Console.WriteLine("Incorrect password, try again");
                Console.WriteLine("Enter your password: ");
                input = Console.ReadLine();
                
            }
            Console.WriteLine("Access Granted");
            */
            ////////////////////////////////////////////////////////////////////
            ///Task 5 - Number Guessing Game
            /*
            int correctNumber = 7;
            int guess;
            int attempts = 0;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());
                attempts  ++;
                if (guess > correctNumber)
                {
                    Console.WriteLine("Too high, try again");
                }
                else if (guess < correctNumber) 
                {
                    Console.WriteLine("Too low, try again");
                }

                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }


            } while (guess != correctNumber);
            {
                Console.WriteLine(" You guessed the correct number in " + attempts + " attempts.");
            }
            */
            //////////////////////////////////////////////////////////////////////
            //Task 6 - Safe Division Calculator
            /*
                try
                {
                    Console.WriteLine("Enter the numerator: ");
                    decimal numerator = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the denominator: ");
                    decimal denominator = decimal.Parse(Console.ReadLine());
                    decimal result = numerator / denominator;
                    Console.WriteLine("The result of the division is: " + result);
                }

                catch (DivideByZeroException)
                { 
           
                  
                 Console.WriteLine("Cannot divide by zero");
                }
                catch (FormatException )
                {
                  Console.WriteLine("Invalid input. Please enter a valid number."); 
                }
                */
            ////////////////////////////////////////////////////////////////////////////
            //Task 7 - Repeating Menu with Exit Option
            /*
            bool keeprunning = true;

            while (keeprunning)
            {
                Console.WriteLine("Print the menue: ");
                Console.WriteLine("1. say Hello");
                Console.WriteLine("2. Show Current Time-of-day Greeting");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                        {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Current Time-of-day Greeting !");
                            break;
                        case 3:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            keeprunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Select 1, 2, or 3.");
                            break;


                    }
                }

                catch (Exception format)

                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            */
            //////////////////////////////////////////////////////////////////////////////
            ///Task 8 - Sum of Even Numbers Only
            /*
            Console.WriteLine("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int Counter = 1; Counter <= number; Counter++)
            {
                if (Counter % 2 == 0)
                {
                    sum = sum + Counter;

                }
            }
                Console.WriteLine("The sum of even numbers from 1 is : " + sum);
                if (number < 0)
                {
                    Console.WriteLine("Please enter a positive number.");
                }
            */
            /////////////////////////////////////////////////////////////////////////////
            ///Task 9 - Validated Positive Number Input

            // Task 9 - Validated Positive Number Input
            /*
            int number = 0;
            bool validInput = false;

            do
            {
                try
                {
                    Console.Write("Enter a positive whole number: ");
                    number = int.Parse(Console.ReadLine());

                    if (number <= 0)
                    {
                        Console.WriteLine("The number must be greater than zero.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }

            } while (validInput == false);


            // Calculate the sum after receiving valid input

            int sum = 0;

            for (int counter = 1; counter <= number; counter++)
            {
                sum = sum + counter;
            }

            Console.WriteLine("The sum from 1 to " + number + " is: " + sum);
            */
            ///////////////////////////////////////////////////////////////////////////////
            //Task 10 - Simple ATM Simulation

            int correctPin = 1234;
            decimal balance = 100.000m;
            bool pinCorrect = false;


            // Part 1: Give the user 3 PIN attempts

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                try
                {
                    Console.Write("Enter your PIN: ");
                    int enteredPin = int.Parse(Console.ReadLine());

                    if (enteredPin == correctPin)
                    {
                        pinCorrect = true;
                        Console.WriteLine("PIN accepted.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN.");

                        Console.WriteLine("Attempts remaining: " + (3 - attempt));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid PIN. Please enter numbers only.");
                    Console.WriteLine("Attempts remaining: " + (3 - attempt));
                }
            }


            // Stop the program if all attempts failed

            if (pinCorrect == false)
            {
                Console.WriteLine("Card Blocked");
                return;
            }


            // Part 2: Show the ATM menu

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n--- ATM Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.Write("Enter deposit amount: ");
                                decimal depositAmount =
                                    decimal.Parse(Console.ReadLine());

                                if (depositAmount <= 0)
                                {
                                    Console.WriteLine(
                                        "Deposit amount must be greater than zero.");
                                }
                                else
                                {
                                    balance = balance + depositAmount;

                                    Console.WriteLine("Deposit successful.");
                                    Console.WriteLine(
                                        "New balance: " +
                                        balance.ToString("F3") +
                                        " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(
                                    "Invalid amount. Please enter a number.");
                            }

                            break;


                        case 2:
                            try
                            {
                                Console.Write("Enter withdrawal amount: ");
                                decimal withdrawalAmount =
                                    decimal.Parse(Console.ReadLine());

                                if (withdrawalAmount <= 0)
                                {
                                    Console.WriteLine(
                                        "Withdrawal amount must be greater than zero.");
                                }
                                else if (withdrawalAmount > balance)
                                {
                                    Console.WriteLine("Insufficient balance.");
                                }
                                else
                                {
                                    balance = balance - withdrawalAmount;

                                    Console.WriteLine("Withdrawal successful.");
                                    Console.WriteLine(
                                        "New balance: " +
                                        balance.ToString("F3") +
                                        " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(
                                    "Invalid amount. Please enter a number.");
                            }

                            break;


                        case 3:
                            Console.WriteLine(
                                "Current balance: " +
                                balance.ToString("F3") +
                                " OMR");
                            break;


                        case 4:
                            Console.WriteLine("Thank you for using the ATM.");
                            keepRunning = false;
                            break;


                        default:
                            Console.WriteLine(
                                "Invalid option. Choose 1, 2, 3, or 4.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(
                        "Invalid input. Please enter a menu number.");
                }
            }
        }

    }

    
    
}
