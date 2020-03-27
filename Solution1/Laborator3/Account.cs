using System;

namespace Laborator3
{
    abstract partial class Account
    { 
        public string Iban { get; set; }
        public decimal Amount { get; private set; }
    
        public decimal Withdraw(decimal amount)
        {
            
            if (Amount < amount)
            {
                throw new InvalidOperationException("Insuficient funds!");
            }
            Amount -= amount;
            return amount;
        }
        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}
