namespace CsharpAdvanceConcepts.LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "SteveVai",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill Gates",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram Nam" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21, StandardID = 2},
                new Student() { StudentID = 6, StudentName = "Bill",  Age = 19, StandardID = 1 } ,
                new Student() { StudentID = 7, StudentName = "Ram" , Age = 22, StandardID = 2 } ,
                new Student() { StudentID = 8, StudentName = "Ronala" , Age = 17 },
                new Student() { StudentID = 9, StudentName = "Steve",  Age = 23, StandardID = 3 } ,
                new Student() { StudentID = 10, StudentName = "Bill kill",  Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 11, StudentName = "Ram Tom" , Age = 20, StandardID = 2 } ,
            };

            // LINQ Classic Approach
            var result = from s in studentList
                         where s.StandardID == 2 && s.Age > 18 && s.Age <= 21
                         select new { StudentID = s.StudentID, StudentName = s.StudentName }; //Creating an object and put that in result

            foreach (var student in result)
            {
                Console.WriteLine($"ID: {student.StudentID} - Name: {student.StudentName}");
            }

            // LINQ Method Chaining / Lambda Style / Extension Method
            var anotherResult = studentList.Where(s => s.StandardID == 2 && s.Age > 18 && s.Age <= 21)
                                           .Select(s => new { StudentID = s.StudentID, StudentName = s.StudentName });

            foreach (var student in result)
            {
                Console.WriteLine($"ID: {student.StudentID} - Name: {student.StudentName}");
            }

        }
    }
}