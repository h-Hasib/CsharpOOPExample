namespace CsharpWithOOP;
class Program
{
    static void Main(string[] args)
    {
        string name, email, accountNumber;
        double amount;

        Console.Write("Customer Name : ");
        name = Console.ReadLine();
        Console.Write("Email : ");
        email = Console.ReadLine();
        Console.Write("Account Number : ");
        accountNumber = Console.ReadLine();

        Account account = new Account(accountNumber);
        Customer customer = new Customer(name, email, account);

        Console.WriteLine("Account created.");

        Console.Write("Deposite Amount : ");
        amount = double.Parse(Console.ReadLine());

        customer.Deposit(amount);

        Console.WriteLine(customer.GetInfo());

        Console.Write("Withdraw Amount : ");
        amount = double.Parse(Console.ReadLine());

        customer.Withdraw(amount);

        Console.WriteLine(customer.GetInfo());
    }
}