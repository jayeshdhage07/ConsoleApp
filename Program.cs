using BankingSystem;
using System;

namespace ConsoleApp 
{
    // Program to run the banking system
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of accounts
            BankAccount savings = new SavingsAccount("Alice", 1000);
            BankAccount current = new CurrentAccount("Bob", 5000);

            while (true)
            {
                Console.WriteLine("\n--- Banking System Menu ---");
                Console.WriteLine("1. Deposit to Savings Account");
                Console.WriteLine("2. Withdraw from Savings Account");
                Console.WriteLine("3. Deposit to Current Account");
                Console.WriteLine("4. Withdraw from Current Account");
                Console.WriteLine("5. Display Savings Account Balance");
                Console.WriteLine("6. Display Current Account Balance");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit into savings account: ");
                        decimal savingsDeposit = GetValidAmount();
                        savings.Deposit(savingsDeposit);
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw from savings account: ");
                        decimal savingsWithdraw = GetValidAmount();
                        savings.Withdraw(savingsWithdraw);
                        break;

                    case "3":
                        Console.Write("Enter amount to deposit into current account: ");
                        decimal currentDeposit = GetValidAmount();
                        current.Deposit(currentDeposit);
                        break;

                    case "4":
                        Console.Write("Enter amount to withdraw from current account: ");
                        decimal currentWithdraw = GetValidAmount();
                        current.Withdraw(currentWithdraw);
                        break;

                    case "5":
                        savings.DisplayBalance();
                        break;

                    case "6":
                        current.DisplayBalance();
                        break;

                    case "7":
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Method to validate and convert user input to a decimal amount
        static decimal GetValidAmount()
        {
            decimal amount;
            while (true)
            {
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out amount) && amount > 0)
                {
                    return amount;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a positive number: ");
                }
            }
        }
    }
}
