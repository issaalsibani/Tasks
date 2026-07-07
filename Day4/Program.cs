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

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static double Area (double lenght, double width)
        {
            return lenght * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public static void Countdown(int startingNumber)
        {
            for (int counter = startingNumber; counter >= 1; counter--)
            {
                Console.WriteLine(counter);
            }
        }

        public static int Multiply( int a, int b)
        {
            return a * b;
        }

        public static double Multiply( double a, double b )
        {
            return a * b;
        }

        public static int Multiply( int a, int b, int c)
        {
            return a * b * c;
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

            // Task 5 - Even or Odd Function
            /*
            Console.WriteLine("Enter a whole number: ");
            int usernumber = int.Parse(Console.ReadLine());

            bool result = IsEven(usernumber);
            if (result)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            */
            ///////////////////////////////////////////////////////////////
            //Task 6 - Rectangle Area & Perimeter Functions
            /*
            Console.Write("Enter the rectangle length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the rectangle width: ");
            double width = double.Parse(Console.ReadLine());

            double area = Area(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            */
            ///////////////////////////////////////////////////////////
            //Task 7 - Grade Letter Function
            /*
            Console.Write("Enter your score: ");
            int userScore = int.Parse(Console.ReadLine());

            string grade = GetGradeLetter(userScore);

            Console.WriteLine("Your grade is: " + grade);
            */
            ///////////////////////////////////////////////////////////////
            //Task 8 - Countdown Function
            /*
            Console.Write("Enter a starting number: ");
            int userNumber = int.Parse(Console.ReadLine());

            Countdown(userNumber);
            */
            ///////////////////////////////////////////////////////////////
            //Task 9 - Overloaded Multiply Function
            int result1 = Multiply(3, 4);
            double result2 = Multiply(2.5, 4.0);
            int result3 = Multiply(2, 3, 4);

            Console.WriteLine("Two integers: " + result1);
            Console.WriteLine("Two doubles: " + result2);
            Console.WriteLine("Three integers: " + result3);



        }
    }
}
