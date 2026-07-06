namespace Day4
{
    internal class Program
    {
        
        public static void Print(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        public static int Square(int number)
        {
            int result = number * number;
            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            return fahrenheit;
        }

        public static void PrintMenue()
        {
            Console.WriteLine("Menue: ");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
        }
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            /*
            Console.WriteLine("Enter your name: ");
            String user = Console.ReadLine();
            Print (user);
            */
            //////////////////////////////////////////////////////////////////////
            //Task 2 - Square Number Function
            /*
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            

            int squaredNumber = Square(userNumber);

            Console.WriteLine("The square is: " + squaredNumber);
            */
            ////////////////////////////////////////////////////////
            //Task 3 - Celsius to Fahrenheit Function
            /*
            Console.Write("Enter the temperature in Celsius: ");
            double userCelsius = double.Parse(Console.ReadLine());

            double result = CelsiusToFahrenheit(userCelsius);

            Console.WriteLine("Temperature in Fahrenheit: " + result);
            */
            //////////////////////////////////////////////////////////////////
            //Task 4 - Fixed Menu Display Function
            //Program.PrintMenue();
        }
    }
}
