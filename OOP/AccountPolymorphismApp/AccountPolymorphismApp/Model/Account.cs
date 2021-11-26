using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        protected int  _accno;
        protected string _accname;
        protected double _balance;
        
        public Account(int paccno,string paccname,double pbalance )
        {
            _accno = paccno;
            _accname = paccname;
            _balance = pbalance;
        }

        public void deposite(double amount)
        {
            _balance += amount;
        }
        public abstract void Withdraw(double amount);

          public int accno 
        {
            get
            {
                return _accno;
            }
        }
        public string accname
        {
            get
            {
                return _accname;
            }
        }
        public double balance 
        {
           get
                {
                return _balance;
            }
            
        }
    }
}
