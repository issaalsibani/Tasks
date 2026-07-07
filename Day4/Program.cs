using System.Reflection.Metadata.Ecma335;

namespace Day4
{
    internal class Program
    {

        /*
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
        */
        /*
        public static double CalculateArea( double a)
        {
            return a * a;
        }

        public static double CalculateArea( double lenght, double width )
        {
            return lenght * width;
        }
        */

        public static double Add(double a, double b)
        {
          return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }
        static double DivideNumbers(double a, double b)
        {
            try
            {
               if ( b == 0)
                {
                    throw new DivideByZeroException();
                }
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannnot divide by zoro");
                return 0;
            }
        }
        public static void DisplayResult(string operationName, double result)
        {
            Console.WriteLine(operationName + " result: " + result);
        }

        static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3;
        }

        public static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        static void PrintReportCard(string studentName, double average, string grade)
        {
            Console.WriteLine("\n--- Student Report Card ---");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Average: " + average.ToString("F2"));
            Console.WriteLine("Grade: " + grade);
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
            /*
            int result1 = Multiply(3, 4);
            double result2 = Multiply(2.5, 4.0);
            int result3 = Multiply(2, 3, 4);

            Console.WriteLine("Two integers: " + result1);
            Console.WriteLine("Two doubles: " + result2);
            Console.WriteLine("Three integers: " + result3);
            */
            ////////////////////////////////////////////////////////////////
            //Task 10 - Overloaded Area Calculator
            /*
            Console.WriteLine("What shape area you want to calculat? ");
            String shape = Console.ReadLine();

            if (shape == "square" )
            {
                Console.WriteLine("Enter side lenght: ");
                double side = double.Parse(Console.ReadLine());
                double square = CalculateArea(side);
                Console.WriteLine("The area of square is " + square);
            }
            else if (shape == "rectangle")
            {
                Console.WriteLine("Enter the lenght of rectangle: ");
                double lenght1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of rectangle");
                double width1 = double.Parse(Console.ReadLine());
                double area = CalculateArea(width1, lenght1);
                Console.WriteLine("The area of rectangle is " + area);
            }
            else
            {
              Console.WriteLine("Invalid input");
            }
            */
            /////////////////////////////////////////////////////////////////
            //Task 11 - Function-Based Calculator
            /*
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n--- Calculator Menu ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 5)
                    {
                        Console.WriteLine("Calculator closed.");
                        keepRunning = false;
                        continue;
                    }

                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Invalid option. Choose from 1 to 5.");
                        continue;
                    }

                    Console.Write("Enter the first number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    double result;

                    switch (choice)
                    {
                        case 1:
                            result = Add(firstNumber, secondNumber);
                            DisplayResult("Addition", result);
                            break;

                        case 2:
                            result = Subtract(firstNumber, secondNumber);
                            DisplayResult("Subtraction", result);
                            break;

                        case 3:
                            result = MultiplyNumbers(firstNumber, secondNumber);
                            DisplayResult("Multiplication", result);
                            break;

                        case 4:
                            result = DivideNumbers(firstNumber, secondNumber);
                            DisplayResult("Division", result);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                }
            }
            */
            /////////////////////////////////////////////////////////////////////////////
            //Task 12 - Student Report Card Generator
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the first subject score: ");
            double score1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second subject score: ");
            double score2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third subject score: ");
            double score3 = double.Parse(Console.ReadLine());

            double average =
                CalculateAverage(score1, score2, score3);

            string grade =
                GetGradeLetter(average);

            PrintReportCard(name, average, grade);
        }
    }
}
