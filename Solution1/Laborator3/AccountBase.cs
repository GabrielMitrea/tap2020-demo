namespace Laborator3
{
    abstract class AccountBase
    {
        public string Iban { get; set; }
        public decimal Amount { get; protected set; }
        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
    
}
