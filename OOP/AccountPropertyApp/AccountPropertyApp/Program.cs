using AccountPropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "yogesh", 1500);
            PrintDetails(acc1);
            acc1.Withdraw(1000);
            PrintDetails(acc1);
            acc1.Deposit(5000);
            PrintDetails(acc1);
            Console.ReadLine();

        }

        private static void PrintDetails(Account acc1)
        {
            Console.WriteLine("Accounr Number: " + acc1.AccountNumber);
            Console.WriteLine("Account Name: " + acc1.AccountName);
            Console.WriteLine("Account Balance: " + acc1.Balance);
            Console.WriteLine();
            
        }
    }
}
