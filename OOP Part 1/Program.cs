using System.ComponentModel.DataAnnotations;

namespace OOP_Part_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        public void Deposit(double amount)
        {
            Balance += amount;
            sendEmail();
        }
        private void sendEmail()
        {
            Console.WriteLine("Successful operation");
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                sendEmail() ;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public double CheckBalance()
        {
            printinformation();
            return Balance;
        }
        private void printinformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
    }
    public class Student
    {
        public int Grade { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        private String email { get; set; }
        int age { get; set; }
        public void Register(string Email)
        {
            email = Email;
            SendEmail();

        }
        private void SendEmail()
        {
            Console.WriteLine("Registration email sent successfully");
        }

    }
    public class Product
    {
        public String ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;  
            }
            else
            {
                Console.WriteLine("Not enough stock");
            }
            LogTransaction();
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetInventoryValue()
        {
            Console.WriteLine("Product information: ");
            PrintDetails();
            return StockQuantity * Price;
        }
        private void PrintDetails()
        {
            Console.WriteLine("Product name: " + ProductName);
            Console.WriteLine("Price: "+ Price);
            Console.WriteLine("Stock quantity: "+  StockQuantity);
        }
    }
    internal class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 123, HolderName = "Issa", Balance = 450 };
        static BankAccount account2 = new BankAccount { AccountNumber = 009, HolderName = "Ali", Balance = 100 };

        static Student student1 = new Student { Grade = 70, Name = "Issa", Address = "Nizwa" };
        static Student student2 = new Student { Grade = 90, Name = "Ali", Address = "Muscat" };

        static Product product1 = new Product { ProductName = "Mouse", Price = 10, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Keyboard", Price = 30, StockQuantity = 10 };

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }
        }
        static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose acount 1 or 2: ");
            int choice = int.Parse (Console.ReadLine());
            if (choice == 2)
            {
                return account2;
            }
            return account1;
        }
        static Student ChooseStudent()
        {
            Console.WriteLine("Choose student 1 or 2: ");
            int choice = int.Parse (Console.ReadLine());
            if (choice == 1)
            {
                return student1;
            }
            return student2;
        }
        static Product ChooseProduct()
        {
            Console.WriteLine("Choose product 1 or 2:");
            int choice = int.Parse(Console.ReadLine());
            if (choice ==1)
            {
                return product1;
            }
            return product2;

        }

        //Case 1 - View Account Details
        static void ViewAccountDetails()
        {
            BankAccount Choosen = ChooseAccount();
            Choosen.CheckBalance();
        }

        //Case 2 - Update Student Address
        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter new address: ");
            String newAddress = Console.ReadLine();
            student.Address = newAddress;
            Console.WriteLine("Address updated to "+ student.Address);
        }

        //Case 3 - Make a Deposit
        static void MakeDeposit()
        {
            BankAccount Choosen = ChooseAccount();
            Console.WriteLine("Entet amount you want to deposit: ");
            double amount = double.Parse (Console.ReadLine());
            Choosen.Deposit(amount);
            Console.WriteLine("Account holder: " + Choosen.HolderName);
            Console.WriteLine("Updated balance: " + Choosen.Balance);

        }

        //Case 4 - Make a Withdrawal
        static void MakeWithdrawal()
        {
            BankAccount Choosen = ChooseAccount();
            Console.WriteLine("Entet amount you want to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            Choosen.Withdraw(amount);
            Console.WriteLine("Updated balance: " + Choosen.Withdraw);
        }

        //Case 5 - View Product Details
        static void ViewProductDetails()
        {
            Product choosen = ChooseProduct();
            double inventoryValue = choosen.GetInventoryValue();
            Console.WriteLine("Total inventory value: " + inventoryValue);
        }

        //Case 6 - Register a Student
        static void RegisterStudent()
        {
            Student selectedStudent = ChooseStudent();

            Console.WriteLine("Enter student email:");
            string email = Console.ReadLine();

            selectedStudent.Register(email);

            Console.WriteLine("Student registered successfully.");
        }
        //Case 7 - Compare Two Account Balances
        static void CompareAccountBalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " has more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        //Case 8 - Restock Product & Stock Level Check
        static void RestockProduct()
        {
            Product choosen = ChooseProduct();
            Console.WriteLine("Enter quantity to restock: ");
            int quantity = int.Parse(Console.ReadLine());
            choosen.Restock(quantity);
            Console.WriteLine("Updated stock quantity: " + choosen.StockQuantity);
            if (choosen.StockQuantity < 10)
            {
                Console.WriteLine("Stock level: Low");
            }
            else if (choosen.StockQuantity >= 10 && choosen.StockQuantity <= 49)
            {
                Console.WriteLine("Stock level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock level: Well Stocked");
            }

        }


    }
}
