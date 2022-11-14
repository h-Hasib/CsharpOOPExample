namespace CsharpOOP.Associativity
{
    public class Salary
    {
        public double Basic { get; private set; }
        public double MedicalPercentage { get; set; }
        public double ConveyancePercentage { get; set; }
        private int NoOfIncrement { get; set; }

        public Salary()
        {
            this.NoOfIncrement = 0;
        }
        public Salary(double basic, double medicalPercentage, double conveyancePercentage) : this()
        {
            Basic = basic;
            MedicalPercentage = medicalPercentage;
            ConveyancePercentage = conveyancePercentage;
        }
        public bool IncreaseBasic(double percentage)
        {
            if (percentage < 100 && percentage > 0)
            {
                this.Basic = this.Basic + (this.Basic * (percentage / 100));
                this.NoOfIncrement++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetMedicalAllowance()
        {
            double amount = this.Basic * (this.MedicalPercentage / 100);
            return amount;
        }
        public double GetConveyanceAllowance()
        {
            double amount = this.Basic * (this.ConveyancePercentage / 100);
            return amount;
        }
        public double GetTotalSalary()
        {
            double total = this.Basic + this.GetMedicalAllowance() + this.GetConveyanceAllowance();
            return total;
        }
        public string GetSalaryInfo()
        {
            string info = "";
            info += $"No of Increments : {this.NoOfIncrement} {Environment.NewLine}";
            info += $"Basic : {this.Basic} {Environment.NewLine}";
            info += $"Medical : {this.GetMedicalAllowance()} {Environment.NewLine}";
            info += $"Conveyance : {this.GetConveyanceAllowance()} {Environment.NewLine}";
            info += $"Total : {this.GetTotalSalary()} {Environment.NewLine}";

            return info;
        }
    }
}
