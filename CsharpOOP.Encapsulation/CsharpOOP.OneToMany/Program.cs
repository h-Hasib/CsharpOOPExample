namespace CsharpOOP.OneToMany
{
    public class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("Computer Science & Engineering", "CSE");

            Student student1 = new Student("181117", "Hasib", "hhasan.cse@gmail.com");
            department.AddStudent(student1);

            Student student2 = new Student("CSE-003", "Shiblee Shahriar", "sshahriar@gmail.com");
            department.AddStudent(student2);

            Student student3 = new Student("CSE-014", "Nabil Ahmed", "nahmed@gmail.com");
            department.AddStudent(student3);

            Console.WriteLine(department.GetInfo());
        }
    }
}