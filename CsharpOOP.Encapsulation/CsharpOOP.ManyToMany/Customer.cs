namespace CsharpOOP.ManyToMany
{
    internal class Customer
    {
        public string NationalID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PresentAddress { get; set; }
        public List<Account> AccountList { get; set; }
        public Customer(string nationalID, string name, string phoneNumber, string presentAddress)
        {
            this.NationalID = nationalID;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.PresentAddress = presentAddress;
            AccountList = new List<Account>();
        }
        public void AddAccountToAccountList(Account anAccount)
        {
            AccountList.Add(anAccount);
        }

        public Account GetAccountByAccNumber(string accNumber)
        {
            foreach (Account account in this.AccountList)
            {
                if (account.AccountNumber == accNumber)
                {
                    return account;
                }
            }
            return null;
        }
    }
}
