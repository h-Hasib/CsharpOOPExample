namespace CsharpOOP.OneToMany
{
    internal class Department
    {
        public string Name { get; set; }
        public string Code { get; set; }

        private List<Student> Students { get; set; }
        public Department()
        {
            Students = new List<Student>();
        }
        public Department(string name, string code) : this()
        {
            this.Name = name;
            this.Code = code;
        }
        public bool AddStudent(Student student)
        {
            if (student != null)
            {
                Students.Add(student);
                return true;
            }
            return false;
        }
        public string GetInfo()
        {
            string info = $"Department Info: {Environment.NewLine}";
            info += $"Code : {this.Code} {Environment.NewLine}";
            info += $"Name : {this.Name} {Environment.NewLine}";
            info += Environment.NewLine;

            if (Students.Count > 0 && Students != null)
            {
                foreach (Student eachStudent in Students)
                {
                    info += eachStudent.GetInfo() + Environment.NewLine;
                }
            }
            else
            {
                info += $"No Students Found {Environment.NewLine}";
            }
            return info;
        }
    }
}
