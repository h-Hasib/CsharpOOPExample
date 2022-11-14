namespace CsharpOOP.Associativity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary(20000, 20, 10);
            Employee employee = new Employee("011181117", "Hasibul Hasan", "hhasan.cse@gmail.com", salary);
            Console.WriteLine(employee.GetInfo());

            Console.WriteLine("Increasing Basic with 10%");
            employee.IncreaseBasic(10);
            Console.WriteLine(employee.GetInfo());

            Console.WriteLine("Increasing Basic with 15%");
            employee.IncreaseBasic(15);
            Console.WriteLine(employee.GetInfo());
        }
    }
}