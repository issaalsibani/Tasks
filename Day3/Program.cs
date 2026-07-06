namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            /*
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int substract = firstNumber - secondNumber;
            decimal result = Math.Abs(substract);
            Console.WriteLine("The absolute difference between the two numbers is: " + result);
            */
            //////////////////////////////////////////////////////////////////
            //Task 2 - Power & Root Explorer
            /*
            Console.WriteLine("Enter the base number:");
            int baseNumber = int.Parse(Console.ReadLine());
            double powerresult = Math.Pow(baseNumber, 2);
            double squareresult = Math.Sqrt(baseNumber);
            Console.WriteLine("The square of the base number is: " + powerresult);
            Console.WriteLine("The square root of the base number is: " + squareresult);
            */
            ///////////////////////////////////////////////////////////////////////////////
            //Task 3 - Name Formatter
            /*
            Console.WriteLine("Enter your first name:");
            String firstName = Console.ReadLine();
            String firstNameUpper = firstName.ToUpper();
            String firstNameLower = firstName.ToLower();
            int lengh = firstName.Length;
            Console.WriteLine("Your first name in uppercase is: " + firstNameUpper);
            Console.WriteLine("Your first name in lowercase is: " + firstNameLower);
            Console.WriteLine("The length of your first name is: " + lengh);
            */
            ///////////////////////////////////////////////////////////////////////////////
            //Task 4 - Subscription End Date
            /*
            Console.WriteLine("Enter your free trial: ");
            int freeTrialDays = int.Parse(Console.ReadLine());
            DateTime freetrial = DateTime.Now;
            DateTime subscriptionEndDate = freetrial.AddDays(freeTrialDays);
            Console.WriteLine("Your subscription will end on: " + subscriptionEndDate.ToString("dd/MM/yyyy"));
            */
            ///////////////////////////////////////////////////////////////////////////////
            //Task 5 - Grade Rounding System
            /*
            Console.WriteLine("Enter your score in decimal: ");
            decimal score = decimal.Parse(Console.ReadLine());
            decimal finalscore = Math.Round(score);
            if (finalscore >= 60 && finalscore <= 100)
            {
                Console.WriteLine("You are passed with a score of: " + finalscore);
            }
            else if (finalscore < 60 && finalscore >= 0)
            {
                Console.WriteLine("You are failed with a score of: " + finalscore);
            }
            else
            {
                Console.WriteLine("Invalid score entered.");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 6 - Password Strength Checker
            /*
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool isTooShort = password.Length < 8;
            bool containsPassword = password.ToLower().Contains("password");

            if (isTooShort)
            {
                Console.WriteLine("Weak: The password must contain at least 8 characters.");
            }
            else if (containsPassword)
            {
                Console.WriteLine("Weak: The password must not contain the word \"password\".");
            }
            else
            {
                Console.WriteLine("Strong password.");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 7 - Clean Name Comparator
            /*
            Console.WriteLine("Enter the first name:");
            String firstName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Enter the name again: ");
            String againName = Console.ReadLine().ToLower().Trim();
           if (firstName == againName)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 8 - Membership Expiry Checker
            /*
            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter the number of valid membership days: ");
                int validDays = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(validDays);

                if (expiryDate.Date >= DateTime.Today)
                {
                    Console.WriteLine("Membership status: Active");
                }
                else
                {
                    Console.WriteLine("Membership status: Expired");
                }

                Console.WriteLine(
                    "Expiry date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Invalid input. Enter the date as yyyy-MM-dd and the days as a whole number.");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 9 - Round Up / Round Down Explorer
            /*
            Console.Write("Enter a decimal number: ");
            double number = double.Parse(Console.ReadLine());

            double nearest = Math.Round(number);
            double roundedUp = Math.Ceiling(number);
            double roundedDown = Math.Floor(number);

            Console.WriteLine("Nearest whole number: " + nearest);
            Console.WriteLine("Always rounded up: " + roundedUp);
            Console.WriteLine("Always rounded down: " + roundedDown);
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 10 - Word Position Finder
            /*
            Console.Write("Enter a full sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();

            // Convert both to lowercase so capital letters do not affect the search
            string sentenceLower = sentence.ToLower();
            string wordLower = word.ToLower();

            int firstPosition = sentenceLower.IndexOf(wordLower);
            int lastPosition = sentenceLower.LastIndexOf(wordLower);

            if (firstPosition == -1)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine("First position: " + firstPosition);
                Console.WriteLine("Last position: " + lastPosition);
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //Task 11 - One-Time Password (OTP) Generator
            /*

            Random random = new Random();
            int otp = random.Next(1000, 10000);

            Console.WriteLine("Your OTP is: " + otp);

            bool verified = false;

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                try
                {
                    Console.Write("Enter the OTP: ");
                    int enteredOtp = int.Parse(Console.ReadLine());

                    if (enteredOtp == otp)
                    {
                        Console.WriteLine("Verified");
                        verified = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect OTP.");
                        Console.WriteLine("Attempts remaining: " + (3 - attempt));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Enter numbers only.");
                    Console.WriteLine("Attempts remaining: " + (3 - attempt));
                }
            }

            if (verified == false)
            {
                Console.WriteLine("Verification Failed");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            //
            try
            {
                Console.Write("Enter your date of birth (yyyy-MM-dd): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                DateTime today = DateTime.Today;

                if (birthDate > today)
                {
                    Console.WriteLine("Invalid date. Birth date cannot be in the future.");
                    return;
                }

                int age = today.Year - birthDate.Year;

               
                if (today.Month < birthDate.Month ||
                    (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age--;
                }

                Console.WriteLine("Age: " + age + " years");
                Console.WriteLine("Day of birth: " + birthDate.DayOfWeek);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date. Please enter it as yyyy-MM-dd.");
            }

        }

    }
    
}
