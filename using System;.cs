using System;
using System.Collections.Generic;

namespace FinanceTracker
{
    class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    class Program
    {
        static List<Transaction> transactions = new List<Transaction>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Finance Tracker");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View Transactions");
                Console.WriteLine("3. Calculate Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddTransaction();
                        break;
                    case "2":
                        ViewTransactions();
                        break;
                    case "3":
                        CalculateBalance();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTransaction()
        {
            Console.WriteLine("Add Transaction");
            Console.WriteLine("----------------");
            Console.Write("Enter the transaction date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the transaction description: ");
            Console.WriteLine("1. Income");
            Console.WriteLine("2. Expense");
            Console.WriteLine("3. Exit");
            string description = Console.ReadLine();
            Console.Write("Enter the transaction amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Transaction transaction = new Transaction
            {
                Date = date,
                Description = description,
                Amount = amount
            };

            bool isRunning = true;
            {
                switch (description)

                {
                    case "1":
                        description = "Income";
                        transactions.Add(transaction);
                        break;
                    case "2":
                        description = "Expense";
                        transaction.Amount *= -1;
                        transactions.Add(transaction);
                        break;
                    case "3":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;



                }
            }



            Console.WriteLine("Transaction added successfully!");
        }

        static void ViewTransactions()
        {
            Console.WriteLine("View Transactions");
            Console.WriteLine("----------------");

            foreach (var transaction in transactions)
            {
                string type = transaction.Amount >= 0 ? "Income" : "Expense";
                Console.WriteLine($"{transaction.Date.ToShortDateString()} - {type} - P{Math.Abs(transaction.Amount)}");
            }
        }

        static void CalculateBalance()
        {
            Console.WriteLine("Calculate Balance");
            Console.WriteLine("----------------");

            decimal balance = 0;

            foreach (var transaction in transactions)
            {
                balance += transaction.Amount;
            }

            Console.WriteLine($"Current Balance: P{balance}");
        }
    }
}
