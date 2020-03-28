namespace Laborator3
{
    class Program
    {
        static void Main(string[] args)
        {
            var debitCalculator = new DebitAccountWithdrawalFeeCalculator();
            WithdrawlAndDepositAccount debitAccount = new DebitAccount();
            Atm.DepositMoneyTo(debitAccount, 100);
            Atm.WithdrawMoneyFrom(debitAccount,50,debitCalculator);

            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            WithdrawlAndDepositAccount creditAccount = new CreditAccount();
            Atm.DepositMoneyTo(creditAccount, 100);
            Atm.WithdrawMoneyFrom(creditAccount, 150, new DummyCalculator());
            
            TestWithdrawal(new DebitAccount());
           

        }
        static void TestWithdrawal(WithdrawlAndDepositAccount account)
        {
            var prevAmount = account.Amount;
            Atm.DepositMoneyTo(account, 50);
            Atm.WithdrawMoneyFrom(account, 50, new DummyCalculator());
            if (account.Amount == prevAmount)
            {
                System.Console.WriteLine("Test passed");

            }
        }
       class DummyCalculator : IWithdrawalFeeCalculator
        {
            public decimal CalculateAmountToWithdraw(decimal amount)
            {
                return 50m;
            }
        }
    }
}
