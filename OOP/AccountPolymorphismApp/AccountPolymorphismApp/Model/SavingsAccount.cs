using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingsAccount:Account
    {
       

        public SavingsAccount(int paccno, string paccname, double pbalance):base(paccno, paccname, pbalance)
        {
           
        }
        public override void Withdraw(double amount)
        {
            int min_balance = 500;
            if( (balance - amount )>min_balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("limit reached...");
            }
        }
       

     
    }
}
