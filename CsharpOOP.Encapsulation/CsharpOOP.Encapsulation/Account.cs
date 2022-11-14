namespace CsharpWithOOP
{
    internal class Account
    {
        public string AccountNo { get; set; }
        public DateTime OpeningDate { get; set; }
        public double Balance { get; private set; }

        public Account()
        {
            this.Balance = 0;
            this.OpeningDate = DateTime.Now;
        }

        public Account(string accountNo) : this()
        {
            this.AccountNo = accountNo;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance > 500)
            {
                Balance -= amount;
            }
        }
        public string GetInfo()
        {
            string text = "";
            text += $"Account Name : {this.AccountNo} {Environment.NewLine}";
            text += $"Opening Date : {this.OpeningDate} {Environment.NewLine}";
            text += $"Balance : {this.Balance}";

            return text;
        }
    }
}

