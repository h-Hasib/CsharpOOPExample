namespace CsharpOOP.Associativity
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private Salary Salary { get; set; }

        public Employee()
        {
            Salary = new Salary();
        }
        private Employee(string id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
        public Employee(string id, string name, string email, Salary salary) : this(id, name, email)
        {
            this.Salary = salary;
        }

        public double GetBasic()
        {
            return Salary.Basic;
        }
        public bool IncreaseBasic(double percentage)
        {
            return Salary.IncreaseBasic(percentage);
        }
        public double GetMedicalAllowance()
        {
            return Salary.GetMedicalAllowance();
        }
        public double GetConveyanceAllowance()
        {
            return Salary.GetConveyanceAllowance();
        }
        public double GetTotalSalary()
        {
            return Salary.GetTotalSalary();
        }
        public string GetInfo()
        {
            string info = "";
            info += $"Employee ID : {this.Id} {Environment.NewLine}";
            info += $"Name : {this.Name} {Environment.NewLine}";
            info += $"Email : {this.Email} {Environment.NewLine}";
            info += Salary.GetSalaryInfo();
            return info;
        }
    }
}
