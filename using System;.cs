using System;

namespace FinanceTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Finance Tracker");

            Console.WriteLine("Enter your income for the month:");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your expenses for the month:");
            double expenses = Convert.ToDouble(Console.ReadLine());

            double netIncome = income - expenses;

            Console.WriteLine("Your total income for the month is: " + income);
            Console.WriteLine("Your total expenses for the month is: " + expenses);
            Console.WriteLine("Your net income for the month is: " + netIncome);

            Console.ReadKey();
        }
    }
}
