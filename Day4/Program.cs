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
            
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            

            int squaredNumber = Square(userNumber);

            Console.WriteLine("The square is: " + squaredNumber);
            */
            ////////////////////////////////////////////////////////
            

        }
    }
}
