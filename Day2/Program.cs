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
            
            

        }

    }
    
}
