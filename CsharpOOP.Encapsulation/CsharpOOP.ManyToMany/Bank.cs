namespace CsharpOOP.ManyToMany
{
    internal class Bank
    {
        public List<Customer> CustomerList { get; set; }
        public Bank()
        {
            CustomerList = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {
            CustomerList.Add(customer);
        }
        public Customer GetCustomerByNid(string nid)
        {
            foreach (var item in CustomerList)
            {
                if (item.NationalID == nid)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
