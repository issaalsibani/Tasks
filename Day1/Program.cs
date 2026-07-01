namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            Console.WriteLine("Enter your age: ");
            Console.WriteLine("Enter your height: ");

            String userName = Console.ReadLine();
            int userAge = int.Parse(Console.ReadLine());
            float userHeight = float.Parse(Console.ReadLine());
            bool student = userAge >= 6 && userAge <= 23;

            Console.Write("Name:" + userName);
            Console.Write(" Age:" + userAge);
            Console.Write(" Height:" + userHeight);
            Console.Write(" Student:" + student);

        }
    }
}
