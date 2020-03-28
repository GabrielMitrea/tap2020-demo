using System;

namespace Laborator3
{
    abstract class WithdrawalFeeCalculator
        {
            public decimal CalculateAmountToWithdraw(decimal amount)
        {
                var commision = CalculateCommision(amount);
                return amount + commision;
            }
        protected abstract decimal CalculateCommision(decimal amouunt);
            
        }
    }

