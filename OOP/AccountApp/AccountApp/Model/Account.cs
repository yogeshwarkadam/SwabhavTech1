using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    class Account
    {
        public const double _defaultBalance = 500;
        private readonly int _accountnumber;
        private readonly string _name;
        private double _balance;

        public Account(int paccountnumber, string pname, double pbalance)
        {
            _accountnumber = paccountnumber;
            _name = pname;
            _balance = pbalance;
        }
        public Account(int paccountnumber, string pname)
        {
            _accountnumber = paccountnumber;
            _name = pname;
        }
        public void Deposit(double amount)
        {
            _balance += amount;   //balance = balance + amount
           
        }
        public void Withdraw(double amount)
        {
            
            
                if (amount <= _balance && (_balance - amount) >= _defaultBalance)
                {
                    _balance -= amount;   //balance = balance - amount
                    Console.WriteLine("transaction succeed...you debited amount: " + amount);
                }
                else
                {
                    Console.WriteLine("Transaction failed...you dont have sufficient balance");
                }
            
        }

        public int GetAccountNumber()
        {
            return _accountnumber;
        }
        public string GetAccountName()
        {
            return _name;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
