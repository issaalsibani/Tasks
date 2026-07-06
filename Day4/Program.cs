namespace Day4
{
    internal class Program
    {
        
        public static void Print(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.WriteLine("Enter your name: ");
            String user = Console.ReadLine();
            Print (user);
            //////////////////////////////////////////////////////////////////////
            

        }
    }
}
