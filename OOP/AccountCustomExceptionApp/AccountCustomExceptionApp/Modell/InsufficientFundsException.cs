using System;
using System.Runtime.Serialization;

namespace AccountApp.Model
{
    [Serializable]
    internal class InsufficientFundsException : Exception
    {
        private Account account;
        private double amount;

        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(Account account, double amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsufficientFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}