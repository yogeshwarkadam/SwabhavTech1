using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Modell
{
    class InsufficientFundException : Exception
    {
        private string _message;
        public InsufficientFundException(Account acc1, double Withdrawamount)
        {
            _message = "transaction account number:" + Convert.ToString(acc1.GetAccountNumber())
                + "to mainatain minimum balance:" + (acc1.GetAccountName()) +
            ":" + acc1.GetBalance() +"withdraw amount: " + Convert.ToString(Withdrawamount);
        }
        public override string Message
        {
            get
            {

                return _message;

            }
        }
    }
}
