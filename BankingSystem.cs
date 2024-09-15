using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BankingSystem
    {
        public string? bankAccName;
        public int? accNumber;
        public int? balance;

        public void BankAccount()
        {
            balance = 250000;
        }

        public void getAccDetails()
        {
            Console.WriteLine("Enter bank Bank name");
            string? userInput1 = Console.ReadLine();
            bankAccName = userInput1;

            Console.WriteLine("Enter bank account number");
            string? userInput2 = Console.ReadLine();
            accNumber = Convert.ToInt32(userInput2);
            Console.WriteLine($"Enter account has been created details are \n {bankAccName}, \n {accNumber} ");
            Console.WriteLine("--------------------------------------------");
        }

        public void checkAccount()
        {
            if(accNumber != null && bankAccName != null)
            {
                Console.WriteLine($"Your bank account name is: {bankAccName} and bank account no is {accNumber}");
                Console.WriteLine("--------------------------------------------");
            }
        }

        public void deposit()
        {
            Console.WriteLine("Enter Enter account details where you want to deposit");
            getAccDetails();
            Console.WriteLine("Enter amount you want to deposit");
            string? userInput3 = Console.ReadLine();
            balance = Convert.ToInt32(userInput3);
            Console.WriteLine("--------------------------------------------");
        }

        public void withdraw()
        {
            Console.WriteLine("Enter Enter account details where you want to withdraw");
            checkAccount();
            Console.WriteLine("Enter amount you want to withdraw");
            string? userInput4 = Console.ReadLine();

            if(Convert.ToInt32(userInput4) < 0 && Convert.ToInt32(userInput4) <= balance)
            {
                Console.WriteLine("you don't have sufficient balance");
            }
            else
            {
                balance = balance - Convert.ToInt32(userInput4);
                Console.WriteLine($"You withdraw {Convert.ToInt32(userInput4)}, remaining balance is {balance}");
            }
        }
    }
}
