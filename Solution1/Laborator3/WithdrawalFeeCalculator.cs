using System;

namespace Laborator3
{
    abstract class WithdrawalFeeCalculator : IWithdrawalFeeCalculator
    {
        public decimal CalculateAmountToWithdraw(decimal amount)
        {
            var commision = CalculateCommision(amount);
            return amount + commision;
        }
        protected abstract decimal CalculateCommision(decimal amouunt);

    }
}

