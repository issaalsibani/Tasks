namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer

            Console.WriteLine("Enter a starting number: ");
            int startingNumber = int.Parse(Console.ReadLine()); 
            int counter = 0;
            for (counter = startingNumber; counter >= 1; counter --) 

            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
