using System;

namespace BankingSystem
{
    // Abstract class defining common structure for a bank account
    abstract class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; protected set; }

        // Constructor for initializing account details
        public BankAccount(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        // Abstract method for depositing money, must be implemented by derived classes
        public abstract void Deposit(decimal amount);

        // Abstract method for withdrawing money, must be implemented by derived classes
        public abstract void Withdraw(decimal amount);

        // Non-abstract method to display the balance, common to all types of accounts
        public void DisplayBalance()
        {
            Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.DisplayBalance)} {AccountHolder}'s Account Balance: {Balance:C}");
        }
    }

    // SavingsAccount inherits from BankAccount and provides specific implementation for deposit and withdraw
    class SavingsAccount : BankAccount
    {
        private const decimal WithdrawalLimit = 500; // Example limit for withdrawals

        public SavingsAccount(string accountHolder, decimal initialBalance)
            : base(accountHolder, initialBalance) { }

        // Implementation of deposit
        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.DepositSuccess)} {amount:C} to {AccountHolder}'s savings account.");
            }
            else
            {
                Console.WriteLine(Messages.GetMessage(Messages.MessageType.InvalidInput));
            }
        }

        // Implementation of withdraw with a limit check
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine(Messages.GetMessage(Messages.MessageType.InsufficientFunds));
            }
            else if (amount > WithdrawalLimit)
            {
                Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.WithdrawalLimitExceeded)} {WithdrawalLimit:C} at once.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.WithdrawSuccess)} {amount:C} from {AccountHolder}'s savings account.");
            }
        }
    }

    // CurrentAccount inherits from BankAccount and has no withdrawal limit
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountHolder, decimal initialBalance)
            : base(accountHolder, initialBalance) { }

        // Implementation of deposit
        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.DepositSuccess)} {amount:C} to {AccountHolder}'s current account.");
            }
            else
            {
                Console.WriteLine(Messages.GetMessage(Messages.MessageType.InvalidInput));
            }
        }

        // Implementation of withdraw without a limit
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine(Messages.GetMessage(Messages.MessageType.InsufficientFunds));
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{Messages.GetMessage(Messages.MessageType.WithdrawSuccess)} {amount:C} from {AccountHolder}'s current account.");
            }
        }
    }
}
