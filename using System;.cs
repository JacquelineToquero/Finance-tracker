
using System;
using System.Collections.Generic;

namespace FinanceTracker
{
    class Transaction
    {
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }

        public Transaction(string type, DateTime date, string description, string category, double amount)
        {
            Type = type;
            Date = date;
            Description = description;
            Category = category;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Date: {Date}, Description: {Description}, Category: {Category}, Amount: {Amount}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n ------------------------------ ");
            Console.WriteLine("|        FINANCE TRACKER       |");
            Console.WriteLine(" ------------------------------ ");

            List<string> categories = new List<string>();
            categories.Add("Food");
            categories.Add("Transportation");

            List<Transaction> transactions = new List<Transaction>();

            DisplayMenu();

            string choice = Console.ReadLine();

            while (choice != "0")
            {
                switch (choice)
                {
                    case "1":
                        AddTransaction(transactions, categories);
                        break;
                    case "2":
                        RemoveTransaction(transactions);
                        break;
                    case "3":
                        Console.WriteLine("\n ------------------------------ ");
                        Console.WriteLine("|       VIEW TRANSACTIONS      |");
                        Console.WriteLine(" ------------------------------ ");
                        ViewTransactions(transactions);
                        break;
                    case "4":
                        CalculateBalance(transactions);
                        break;
                    case "5":
                        ViewCategories(categories);
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        break;
                }
                DisplayMenu();
                choice = Console.ReadLine();
            }

        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. Remove Transaction");
            Console.WriteLine("3. View Transactions");
            Console.WriteLine("4. Calculate Balance");
            Console.WriteLine("5. View Categories");
            Console.WriteLine("Press 0 to Exit.");

            Console.Write("\nEnter your choice: ");

        }

        static void AddTransaction(List<Transaction> transactions, List<string> categories)
        {
            Console.WriteLine("\n ------------------------------ ");
            Console.WriteLine("|        ADD TRANSACTIONS      |");
            Console.WriteLine(" ------------------------------ ");
            Console.Write("Enter the transaction date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("\nChoose transaction type: ");
            Console.WriteLine("1. Income");
            Console.WriteLine("2. Expense");
            Console.WriteLine("Press 0 to Exit.");
            Console.Write("\nEnter choice: ");
            string type = Console.ReadLine() ?? string.Empty;
            Console.Write("\nEnter description: ");
            string description = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nChoose a category.");
            int i = 1;
            foreach (string var in categories)
            {
                Console.WriteLine($"{i}. {var}");
                i++;
            }
            Console.Write("\nEnter choice: ");
            string category = Console.ReadLine() ?? string.Empty;
            Console.Write("\nEnter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());


            switch (type)
            {
                case "1":
                    type = "Income";
                    transactions.Add(new Transaction(type, date, description, category, amount));
                    break;
                case "2":
                    type = "Expense";
                    amount *= -1;
                    transactions.Add(new Transaction(type, date, description, category, amount));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nTransaction successfully added!");

        }

        static void RemoveTransaction(List<Transaction> transactions)
        {
            Console.WriteLine("\nChoose a transaction you want to remove.");
            ViewTransactions(transactions);
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            transactions.RemoveAt(choice);


            Console.WriteLine("\nTransactions successfully updated!");



        }

        static void ViewTransactions(List<Transaction> transactions)
        {


            foreach (var transaction in transactions)
            {

                Console.WriteLine($"{transaction.Date.ToShortDateString()} - {transaction.Type} - P{Math.Abs(transaction.Amount)}");
            }
        }

        static void CalculateBalance(List<Transaction> transactions)
        {
            double totalBalance = 0;

            foreach (var transaction in transactions)
            {
                totalBalance = +transaction.Amount;
            }
        }

        static void ViewCategories(List<string> categories)
        {
            int i = 1;
            Console.WriteLine("\n ------------------------------ ");
            Console.WriteLine("|          CATEGORIES          |");
            Console.WriteLine(" ------------------------------ ");
            foreach (var category in categories)
            {
                Console.WriteLine($"{i}. {category}");
                i++;
            }

        }
    }
}
