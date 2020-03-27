namespace Laborator3
{
    class DebitAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0m;
        }
    }
}
