using BankingSystem;
using System;

namespace ConsoleApp 
{
    // Program to run the banking system
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.GetMessage(Messages.MessageType.Welcome));

            // Creating instances of accounts
            BankAccount savings = new SavingsAccount("Alice", 1000);
            BankAccount current = new CurrentAccount("Bob", 5000);

            while (true)
            {
                DisplayMenu();

                Console.WriteLine(Messages.GetMessage(Messages.MessageType.MenuPrompt));
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.DepositPrompt));
                        decimal savingsDeposit = GetValidAmount();
                        savings.Deposit(savingsDeposit);
                        break;

                    case "2":
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.WithdrawPrompt));
                        decimal savingsWithdraw = GetValidAmount();
                        savings.Withdraw(savingsWithdraw);
                        break;

                    case "3":
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.DepositPrompt));
                        decimal currentDeposit = GetValidAmount();
                        current.Deposit(currentDeposit);
                        break;

                    case "4":
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.WithdrawPrompt));
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
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.ExitMessage));
                        return;

                    default:
                        Console.WriteLine(Messages.GetMessage(Messages.MessageType.InvalidOption));
                        break;
                }
            }
        }

        // Method to display the menu options
        static void DisplayMenu()
        {
            Console.WriteLine("\n--- Banking System Menu ---");
            Console.WriteLine("1. Deposit to Savings Account");
            Console.WriteLine("2. Withdraw from Savings Account");
            Console.WriteLine("3. Deposit to Current Account");
            Console.WriteLine("4. Withdraw from Current Account");
            Console.WriteLine("5. Display Savings Account Balance");
            Console.WriteLine("6. Display Current Account Balance");
            Console.WriteLine("7. Exit");
        }

        // Method to validate and convert user input to a decimal amount
        static decimal GetValidAmount()
        {
            decimal amount;
            while (true)
            {
                Console.WriteLine(Messages.GetMessage(Messages.MessageType.EnterAmount));
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out amount) && amount > 0)
                {
                    return amount;
                }
                else
                {
                    Console.WriteLine(Messages.GetMessage(Messages.MessageType.InvalidInput));
                }
            }
        }
    }
}
