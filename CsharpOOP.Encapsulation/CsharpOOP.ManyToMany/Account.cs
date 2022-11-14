namespace CsharpOOP.ManyToMany
{
    internal class Account
    {
        public DateTime OpeningDate { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
        public Customer Owner { get; set; }
        public Account(string accountNumber, int accountType, Customer aCustomer)
        {
            //Write logic to assign object
            this.OpeningDate = DateTime.Now;
            this.AccountNumber = accountNumber;
            if (accountType == 1)
            {
                this.AccountType = "student";
            }
            else
            {
                this.AccountType = "savings";
            }
            this.AccountBalance = 0;
            this.Owner = aCustomer;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.AccountBalance += amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(double amount)
        {
            double newBalance = this.AccountBalance - amount;
            if (newBalance > 0)
            {
                this.AccountBalance = newBalance;
                return true;
            }
            return false;
        }
        public string AccountInfo()
        {
            string message = "";
            message += $"A/C No: {this.AccountNumber} | ";
            message += $"Type: {this.AccountType} | ";
            message += $"Balance: {this.AccountBalance} | ";
            return message;
        }
    }
}
