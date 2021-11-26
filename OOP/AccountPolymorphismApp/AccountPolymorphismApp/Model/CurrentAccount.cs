using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {


        public CurrentAccount(int paccno, string paccname, double pbalance) : base(paccno, paccname, pbalance)
        {
          
        }
    public override void Withdraw(double amount)
    {
        if (DoOverDraftCheck())
        {
            _balance = balance - amount;
        }
    }

        private bool DoOverDraftCheck()
        {
            return true;
        }
    }
}
