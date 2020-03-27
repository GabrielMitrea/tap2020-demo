using System;

namespace Laborator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account debitAccount = new DebitAccount();
            debitAccount.Deposit(100);
            debitAccount.Withdraw(50);
            Console.WriteLine("Debi account: {0}.", debitAccount.Amount);
            Account creditAccount = new CreditAccount();
            creditAccount.Deposit(100);
            creditAccount.Withdraw(50);
            Console.WriteLine("Credit account: {0}.", creditAccount.Amount);


        }
    }
}
