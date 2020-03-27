using System;

namespace Laborator3
{
    
        class WithdrawalFeeCalculator
        {
            public decimal CalculateAmountToWithdraw(Account account,decimal amount)
            {
                var commision = GetCommision(account);
                return amount +amount * commision;
            }

            private decimal GetCommision(Account account)
            {
                if(account is CreditAccount)
                {
                    return 0.2m;

                }
                if(account is DebitAccount)
                {
                    return 0m;
                }
                if (account is CreditAccount)
                {
                    return .12m;
                }
                throw  new InvalidOperationException("Unnknown account type!");
            }
        }
    }

