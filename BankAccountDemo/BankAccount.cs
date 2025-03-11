namespace BankAccount {
    public class BankAccount
    {
        private string accountHolder;
        private decimal balance;

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }
        public void deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void withdraw(decimal amount)
        {
            this.balance -= amount;
        }
        public decimal Balance { get { return this.balance; } }
        public string AccountHolder { get { return this.accountHolder; } }
    }
}

