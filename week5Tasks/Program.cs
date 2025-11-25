using System;

namespace OOPWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TASK 1: Encapsulation ===");
            BankAccount acc = new BankAccount("ACC1001", 500);
            Console.WriteLine("Account Number: " + acc.AccountNumber);
            acc.Deposit(200);
            acc.Withdraw(100);
            Console.WriteLine("Final Balance: " + acc.Balance);
        }
    }
}