using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "yogesh", 1500);
            acc1.Withdraw(1200);
            
            
            Console.WriteLine("Accounr Number: " + acc1.GetAccountNumber());
            Console.WriteLine("Account Name: " + acc1.GetAccountName());
            Console.WriteLine("Account Balance: " + acc1.GetBalance());
            Console.WriteLine();


            Account acc2 = new Account(102, "vallabh");
            acc2.Deposit(5000);
           
            Console.WriteLine("Account number: " + acc2.GetAccountNumber());
            Console.WriteLine("Account number: " + acc2.GetAccountName());
            Console.WriteLine("account balance: " + acc2.GetBalance());

            Console.ReadLine();
        }
      
    }
}
