namespace CsharpOOP.ManyToMany
{
    static class Program
    {
        static int printMainMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1) Add Customer.");
            Console.WriteLine("2) Add Account.");
            Console.WriteLine("3) Transaction.");
            Console.WriteLine("4) Show Report.");
            Console.WriteLine("5) Exit.");
            Console.Write("Press(1/2/3/4/5)_");

            // write some logic if anyone give wrong input
            int.TryParse(Console.ReadLine(), out int choice);

            Console.WriteLine("--------------------");
            return choice;
        }
        static void AddCustomer(Bank bank)
        {
            string nid, name, phoneNumber, presentAddress;

            Console.WriteLine("--Customer Information--");

            Console.Write("National ID: ");
            nid = Console.ReadLine();

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Phone Number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Present Address: ");
            presentAddress = Console.ReadLine();

            Customer customer = new Customer(nid, name, phoneNumber, presentAddress);
            bank.AddCustomer(customer);
        }
        static void ShowCustomerList(Bank bank)
        {
            Console.WriteLine($"{Environment.NewLine}\t*Customer List*");
            foreach (var item in bank.CustomerList)
            {
                Console.WriteLine($"NID: {item.NationalID}, Name: {item.Name}");
            }
        }
        static void AddAccount(Bank bank)
        {
            string accountNumber;

            Console.WriteLine("--Account Information--");

            Console.Write("Account Number: ");
            accountNumber = Console.ReadLine();

            Console.WriteLine("Account Type:");
            Console.WriteLine("\t1) Student Account.");
            Console.WriteLine("\t2) Savings Account.");
            Console.Write("\tPress (1/2)_");
            int.TryParse(Console.ReadLine(), out int type);

            ShowCustomerList(bank);

            Console.Write("Choose a customer by NID: ");
            string nidInput = Console.ReadLine();

            Customer inputCustomer = bank.GetCustomerByNid(nidInput);

            Account anAccount = new Account(accountNumber, type, inputCustomer);

            inputCustomer.AddAccountToAccountList(anAccount);
        }
        static void ShowAccountNumberList(Customer aCustomer)
        {
            foreach (var customer in aCustomer.AccountList)
            {
                Console.WriteLine("\t" + customer.AccountInfo());
            }
        }
        static void MakeTransaction(Bank bank)
        {
            Console.WriteLine("--Transaction in Account--");

            ShowCustomerList(bank);

            Console.Write("Choose a customer by NID: ");
            string nidInput = Console.ReadLine();
            Customer inputCustomer = bank.GetCustomerByNid(nidInput); //get a customer

            ShowAccountNumberList(inputCustomer);  //show the account associated with input Customer

            Console.Write("Select an account by Account Number: ");
            string inputAccNumber = Console.ReadLine();

            Account anAccount = inputCustomer.GetAccountByAccNumber(inputAccNumber);

            Console.WriteLine("Press\n\t1)Deposit\n\t2)Withdraw");
            Console.Write("\t\t>>_ ");
            int.TryParse(Console.ReadLine(), out int choice);
            Console.Write("\t\tAmount: ");
            double.TryParse(Console.ReadLine(), out double amount);
            if (choice == 1)
            {
                bool isSuccess = anAccount.Deposit(amount);
                if (isSuccess)
                {
                    Console.WriteLine("\tDeposit Success.");
                }
                else
                {
                    Console.WriteLine("\tTransaction Failed!");
                }
            }
            else if (choice == 2)
            {
                bool isSuccess = anAccount.Withdraw(amount);
                if (isSuccess)
                {
                    Console.WriteLine("\tWithdraw Success.");
                }
                else
                {
                    Console.WriteLine("\tTransaction Failed!");
                }
            }
            else
            {
                Console.WriteLine("\tWrong Input.");
            }
        }

        static void ShowReport(Bank bank)
        {
            Console.WriteLine("--Report--");
            Console.WriteLine(" \t>> Customer List::");
            foreach (var customer in bank.CustomerList)
            {
                Console.WriteLine($"\tNID: {customer.NationalID}, Name: {customer.Name}");
                if (customer.AccountList.Count() > 0)
                {
                    Console.WriteLine("\tAccounts: ");
                    foreach (var account in customer.AccountList)
                    {
                        Console.WriteLine("\t" + account.AccountInfo());
                    }
                }
                else
                {
                    Console.WriteLine("This customer has no account.");
                }
            }
        }
        static void Main(string[] args)
        {
            int choice;
            bool isExit = true;

            Bank bank = new Bank();
            do
            {
                choice = printMainMenu();
                switch (choice)
                {
                    case 1:
                        AddCustomer(bank);
                        break;
                    case 2:
                        AddAccount(bank);
                        break;
                    case 3:
                        MakeTransaction(bank);
                        break;
                    case 4:
                        ShowReport(bank);
                        break;
                    default:
                        Console.WriteLine("Exit");
                        isExit = false;
                        break;
                }
                Console.WriteLine(Environment.NewLine + "Press Enter..");
                Console.ReadKey();
                Console.Clear();
            } while (isExit);
        }
    }
}