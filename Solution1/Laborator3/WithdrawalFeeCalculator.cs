using System;

namespace Laborator3
{
    abstract class WithdrawalFeeCalculator
        {
            public decimal CalculateAmountToWithdraw(Account account,decimal amount)
            {
                var commision = CalculateCommision(amount);
                return amount + commision;
            }
        protected abstract decimal CalculateCommision(decimal amouunt);
            
        }
    }

