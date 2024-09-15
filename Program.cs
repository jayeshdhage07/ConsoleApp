using System;

namespace ConsoleApp 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your Bank System");

            BankingSystem myBank = new BankingSystem();
            myBank.createAccount();
            myBank.deposit();
            myBank.withdraw();
        }
    }
}
