using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "yogesh", 5000);
            /*try
            {
                acc1.Withdraw(4501);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("execute not matter exception or not");
                PrintDetails(acc1);

            }*/
            try
            {
                acc1.Withdraw(4501);
            }
            catch(InsufficientExecutionStackException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("execute not matter exception or not");
                PrintDetails(acc1);
            }
            Console.WriteLine("end of main");
            Console.ReadLine();
        }

        private static void PrintDetails(Account acc1)
        {
            Console.WriteLine("account number: "+ acc1.GetAccountNumber());
            Console.WriteLine("account name: "+ acc1.GetAccountName());
            Console.WriteLine("account Balance: "+ acc1.GetBalance());
        }
    }
}
