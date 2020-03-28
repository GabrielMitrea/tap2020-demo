using System;

namespace Laborator3
{
    class DepositAccount : Account
    {
        protected override decimal WithdrawInternal(decimal amount)
        {
            throw new InvalidOperationException("Cannot withdraw from Deposit account");
        }
    }
}
