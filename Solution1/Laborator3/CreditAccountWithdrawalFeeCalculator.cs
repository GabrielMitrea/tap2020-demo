namespace Laborator3
{
    class CreditAccountWithdrawalFeeCalculator : WithdrawalFeeCalculator
    {
        protected override decimal CalculateCommision(decimal amount)
        {
            return amount* 0.2m;
        }
    }
    }

