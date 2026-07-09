namespace Day5
{
    internal class Program
    {
        static double GetAverage(List<int> gradeList)
        {
            int sum = 0;

            foreach (int grade in gradeList)
            {
                sum += grade;
            }

            return (double)sum / gradeList.Count;
        }



        static int GetFirstFailing(List<int> gradeList)
        {
            return gradeList.Find(x => x < 60);
        }
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            /*
            int[] grades = new int[5];
             int counter;
            for ( counter = 0; counter < grades.Length; counter ++)
            {
                Console.Write("Enter grade " + (counter + 1) + ": ");
                grades[counter] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The grades are:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            */
            ///////////////////////////////////////////////////////////////
            //Task 2 - Dynamic To-Do List
            /*
            List <String> todoitems = new List<String>();
            todoitems.Add("Orange");
            todoitems.Add("Apples");
            todoitems.Add("Tomato");
            todoitems.Add("Potato");
            todoitems.Add("Grapes");
            foreach (String item in todoitems)
            {
                Console.WriteLine(item);
            }
            */
            /////////////////////////////////////////////////////////
            //Task 3 - Browsing History Stack
            /*
            Stack<string> browsingHistory = new Stack<string>();
            for (int counter = 1; counter <= 3; counter++)
            {
                Console.Write("Enter website URL " + counter + ": ");
                string website = Console.ReadLine();

                browsingHistory.Push(website);
            }

            // Remove the current page to simulate pressing Back
            string pageLeft = browsingHistory.Pop();

            // The new top page is where the user lands
            string currentPage = browsingHistory.Peek();

            Console.WriteLine("You left: " + pageLeft);
            Console.WriteLine("You landed on: " + currentPage);
            */
            ///////////////////////////////////////////////////////////
            ///Task 4 - Customer Service Queue
            /*
            Queue<string> customers = new Queue<string>();
            for (int counter = 1; counter <= 3; counter++)
            {
                Console.Write("Enter customer name " + counter + ": ");
                string customerName = Console.ReadLine();

                customers.Enqueue(customerName);
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Customer served: " + servedCustomer);
            */
            /////////////////////////////////////////////////////////////
            //Task 5 - Array Grade Range
            /*
            int[] grades = new int[5];
            int sum = 0;
            int counter;
            for (counter = 0; counter < grades.Length;  counter++)
            {
                Console.Write("Enter grade " + (counter + 1) + ": ");
                grades[counter] = int.Parse(Console.ReadLine());

                sum = sum + grades[counter];

            }
            Array.Sort(grades);
            int lowestGrade = grades[0];
            int highestGrade = grades[grades.Length - 1];

            double average = (double)sum / grades.Length;

            Console.WriteLine("Lowest grade: " + lowestGrade);
            Console.WriteLine("Highest grade: " + highestGrade);
            Console.WriteLine("Average grade: " + average.ToString("F2"));
            */
            //Task 6 - Filtered Shopping List
            /*
            List<string> shoppingList = new List<string>();

            string item = "";

            while (item.ToLower() != "done")
            {
                Console.Write("Enter an item, or type \"done\" to finish: ");
                item = Console.ReadLine().Trim();

                if (item.ToLower() != "done")
                {
                    shoppingList.Add(item);
                }
            }

            Console.WriteLine("\nShopping list before removal:");

            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine(shoppingItem);
            }

            Console.Write("\nEnter an item to remove: ");
            string itemToRemove = Console.ReadLine().Trim();

            bool wasRemoved = shoppingList.Remove(itemToRemove);

            if (wasRemoved)
            {
                Console.WriteLine(itemToRemove + " was removed.");
            }
            else
            {
                Console.WriteLine(itemToRemove + " was not found.");
            }

            Console.WriteLine("\nShopping list after removal:");

            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine(shoppingItem);
            }
            */
            ///////////////////////////////////////////////////
            //Task 7 - High Score Podium
            /*
            List<int> scores = new List<int>();

            for (int counter = 1; counter <= 5; counter++)
            {
                Console.Write("Enter score " + counter + ": ");
                int score = int.Parse(Console.ReadLine());

                scores.Add(score);
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("\n--- High Score Podium ---");
            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);
            */
            ///////////////////////////////////////////////
            ///Task 8 - Undo Last Action
            /*
            Stack<string> actions = new Stack<string>();

            String action = "";

            while (action.ToLower() != "stop")
            {
                Console.Write("Enter an action, or type \"stop\" to finish: ");
                action = Console.ReadLine();

                if (action.ToLower() != "stop")
                {
                    actions.Push(action);
                }
            }

            Console.WriteLine("\nUndoing last two actions:");

            for (int counter = 1; counter <= 2; counter++)
            {
                if (actions.Count > 0)
                {
                    string undoneAction = actions.Pop();
                    Console.WriteLine("Undone action: " + undoneAction);
                }
                else
                {
                    Console.WriteLine("No more actions to undo.");
                }
            }

            Console.WriteLine("\nRemaining actions:");

            foreach (string remainingAction in actions)
            {
                Console.WriteLine(remainingAction);
            }
            */
            ///////////////////////////////////////////////////////////
            ///Task 9 - Grade Analyzer with Functions
            
            List<int> gradeList = new List<int>();

            Console.Write("How many grades do you want to enter? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter grade: ");
                int grade = int.Parse(Console.ReadLine());

                gradeList.Add(grade);
            }

            double avg = GetAverage(gradeList);
            int firstFail = GetFirstFailing(gradeList);

            Console.WriteLine("Average: " + avg);

            if (firstFail == 0)
            {
                Console.WriteLine("No failing grades found.");
            }
            else
            {
                Console.WriteLine("First failing grade: " + firstFail);
            }
            
            
        }
    }
}
