namespace CsharpWithOOP
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private Account Account { get; set; }

        public Customer()
        {
            Account = new Account();
        }

        public Customer(string name, string email) : this()
        {
            this.Name = name;
            this.Email = email;
        }
        public Customer(string name, string email, Account account) : this(name, email)
        {
            this.Account = account;
        }
        public double GetBalance()
        {
            return Account.Balance;
        }
        public void Deposit(double amount)
        {
            Account.Deposit(amount);
        }
        public void Withdraw(double amount)
        {
            Account.Withdraw(amount);
        }
        public string GetInfo()
        {
            string text = "";
            text += $"Customer Name : {this.Name} {Environment.NewLine}";
            text += $"Email : {this.Email} {Environment.NewLine}";
            text += Account.GetInfo();

            return text;
        }
    }
}
