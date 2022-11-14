namespace CsharpOOP.OneToMany
{
    internal class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Student(string regNo, string name, string email)
        {
            RegNo = regNo;
            Name = name;
            Email = email;
        }
        public string GetInfo()
        {
            string info = "";
            info += $"Reg No : {this.RegNo} {Environment.NewLine}";
            info += $"Name   : {this.Name} {Environment.NewLine}";
            info += $"Email  : {this.Email} {Environment.NewLine}";
            return info;
        }
    }
}
