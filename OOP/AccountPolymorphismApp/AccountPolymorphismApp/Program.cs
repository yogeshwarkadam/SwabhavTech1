using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101, "yogesh", 5000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102, "vinod", 9000);
            PrintDetails(acc2);
            acc1.Withdraw(3000);
            PrintDetails(acc1);
            acc2.Withdraw(6000);
            PrintDetails(acc2);

            Console.ReadLine();
        }

       

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("\naccount number: "+acc.accno);
            Console.WriteLine("account name: " + acc.accname);
            Console.WriteLine("account balance: " + acc.balance);
        }
    }
}
