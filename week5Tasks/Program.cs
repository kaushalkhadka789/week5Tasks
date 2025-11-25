using System;
using System.Runtime.ConstrainedExecution;

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

            Console.WriteLine("\n=== TASK 2: Inheritance ===");
            Car car = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle moto = new Motorcycle { Brand = "Yamaha", Speed = 90, HasCarrier = true };
            car.Start(); car.DisplayInfo(); car.Stop();
            moto.Start(); moto.DisplayInfo(); moto.Stop();

            Console.WriteLine("\n=== TASK 3: Polymorphism (Overloading) ===");
            Printer p = new Printer();
            p.Print("Hello I am Messi");
            p.Print(10);
            p.Print("Repeat", 3);

            //Task 3(b)

            Teacher nepali = new NepaliTeacher { Name = "Ram" };
            Teacher english = new EnglishTeacher { Name = "Kaushal" };

            nepali.Teaching();
            nepali.SalaryInfo();

            english.Teaching();
            english.SalaryInfo();

        }
    }
}