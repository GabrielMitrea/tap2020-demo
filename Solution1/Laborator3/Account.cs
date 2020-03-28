using System;

namespace Laborator3
{
    abstract partial class Account:AccountBase
    { 
       
        public decimal Withdraw(decimal amount)
        {
            return WithdrawInternal(amount);
        }
        protected virtual decimal WithdrawInternal(decimal amount)
        {
            
            if (Amount < amount)
            {
                throw new InvalidOperationException("Insuficient funds!");
            }
            Amount -= amount;
            return amount;
        }
        
    }
    
}
