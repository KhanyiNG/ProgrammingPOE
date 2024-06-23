using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApplication
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            // Type your information and press enter
            // Create a string variable and get user input from the keyboard and store it in the variable
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Surname:");
            string Surname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your gross monthly income:");
            int gross = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your estimated monthly tax deducted:");
            int tax = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your estimated expenditure:");
            int expenses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your monthly groceries:");
            int groc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your monthly water and lights:");
            int water = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your travel costs including petrol costs:");
            int travel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your cellphone costs:");
            int cell = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your other costs:");
            int others = Convert.ToInt32(Console.ReadLine());
            

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Rent");
            Console.WriteLine("2) Buy");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Rent();
                    return true;
                case "2":
                    Buy();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write(" ");
            return Console.ReadLine();
        }

        private static void Rent()
        {
            Console.Clear();
            Console.WriteLine("Please enter your monthly rental");

            Console.WriteLine("Enter your gross:");
            int gross = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your expenses:");
            int expenses = Convert.ToInt32(Console.ReadLine());
            int sum = gross - expenses;

            Console.WriteLine("You have " + sum + " left");

            if (gross > sum)
            {
                Console.WriteLine("You Qualify");
            }
            else
            {
                Console.WriteLine("You Do Not Qualify");
            }

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
            
        private static void Buy()
        {

            int repaymentmonths;
            double purchaseprice, depositamount, gross, expenses, rate, interest, total;
            Console.WriteLine("Enter your gross:");
            gross = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your expenses:");
            expenses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The purchase price : ");
            purchaseprice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The deposit amount : ");
            depositamount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the number of months to repay : ");
            repaymentmonths = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());


            interest = (purchaseprice - depositamount) * (1 + rate / 100 * (repaymentmonths / 12));
            Console.WriteLine("Total Amount :" + interest);
            Console.ReadLine();
            double answer = interest / repaymentmonths;
            Console.WriteLine("You have to pay the amount of " + answer);
            Console.ReadLine();

            Console.WriteLine("");
            double sum = gross - (answer + expenses);

            Console.WriteLine("You have " + sum + " left");
            Console.WriteLine("Therefore ");

            
            Console.WriteLine("");
            Console.ReadLine();


            if (gross > sum)
            {
                Console.WriteLine("You Qualify");
            }
            else
            {
                Console.WriteLine("You Do Not Qualify");
            }
            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nThank you for using our application : {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

    }
}
    



