using System;

namespace BankingSystem
{
    public static class Messages
    {
        // Enum class for storing and displaying all messages
        public enum MessageType
        {
            Welcome = 1,
            DepositSuccess,
            WithdrawSuccess,
            InsufficientFunds,
            WithdrawalLimitExceeded,
            InvalidInput,
            ExitMessage,
            DisplayBalance,
            MenuPrompt,
            EnterAmount,
            DepositPrompt,
            WithdrawPrompt,
            InvalidOption,
        }

        // Method to get message strings based on the MessageType enum
        public static string GetMessage(MessageType messageType)
        {
            return messageType switch
            {
                MessageType.Welcome => "Welcome to the Banking System!",
                MessageType.DepositSuccess => "Successfully deposited",
                MessageType.WithdrawSuccess => "Successfully withdrew",
                MessageType.InsufficientFunds => "Insufficient funds.",
                MessageType.WithdrawalLimitExceeded => "Cannot withdraw more than",
                MessageType.InvalidInput => "Invalid input. Please enter a positive number.",
                MessageType.ExitMessage => "Exiting the system. Goodbye!",
                MessageType.DisplayBalance => "Displaying account balance:",
                MessageType.MenuPrompt => "Choose an option:",
                MessageType.EnterAmount => "Enter the amount:",
                MessageType.DepositPrompt => "Enter amount to deposit:",
                MessageType.WithdrawPrompt => "Enter amount to withdraw:",
                MessageType.InvalidOption => "Invalid option. Please try again.",
                _ => "Unknown message."
            };
        }
    }
}
