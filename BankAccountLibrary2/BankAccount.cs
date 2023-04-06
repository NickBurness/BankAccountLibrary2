namespace BankAccountLibrary2
{
    public class BankAccount
    {
        public BankAccount(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; }
        public decimal Balance { get; set; }

        public bool Validate()
        {
            return Name.Equals("Steve");
        }

        public bool ValidateStartingBalance()
        {
            return Balance.Equals(10);
        }

        public void Withdraw(decimal amount)
        {
            if (amount !>= Balance)
            {
                Balance = Balance - amount;
            }
        }
    }
}