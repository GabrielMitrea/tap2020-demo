namespace Laborator3
{
    class DebitAccountWithdrawalFeeCalculator : WithdrawalFeeCalculator
    {
        protected override decimal CalculateCommision(decimal amount)
        {
            return 0m;
        }
    }
    }

