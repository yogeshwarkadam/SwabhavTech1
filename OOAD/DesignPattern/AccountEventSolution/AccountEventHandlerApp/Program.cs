using AccountEventLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account( 101,"yogeshwar", 6000);
            account1.OnBalanceChanged += PrintDetails;
            account1.Deposit(2000);
            account1.Withdraw(1000);
            Console.ReadKey();
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("\nAccount Details: ");
            Console.WriteLine("Account number: {0}\nName: {1}\nBalance: {2}", account.Accno, account.name, account.balance);
        }
    }
}
