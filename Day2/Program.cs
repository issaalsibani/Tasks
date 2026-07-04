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
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int counter;
            int multiplication = 0;
            for (counter = 1; counter <= 10; counter++)
            {
                multiplication = number * counter;
                Console.WriteLine(number + " x " + counter + " = " + multiplication);
            }

        }
    }
}
