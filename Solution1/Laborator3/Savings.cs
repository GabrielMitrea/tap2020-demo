namespace Laborator3
{
    class Savings : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * .12m;
        }
    }
}
