﻿using System;

namespace ConsoleApp 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your Bank System");

            BankingSystem myBank = new BankingSystem();
            myBank.getAccDetails();
            myBank.deposit();
            myBank.withdraw();
        }
    }
}
