using System;

namespace Laborator3
{
    abstract class Account
    {
        public string Iban { get; set; }
        public decimal Amount { get; private set; }
        protected abstract decimal CalculateWithdrawalFee(decimal amount);
        public decimal Withdraw(decimal amount)
        {
            decimal amountToWithdraw = amount + CalculateWithdrawalFee(amount);
            if (Amount < amountToWithdraw)
            {
                throw new InvalidOperationException("Insuficient funds!");
            }
            Amount -= amountToWithdraw;
            return amount;
        }
        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}
