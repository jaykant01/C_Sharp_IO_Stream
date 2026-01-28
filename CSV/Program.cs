namespace CSV;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //string filePath = @"D:\C# All Repo\C_Sharp_IO_Stream\CSV\Student\students.csv";
        //List<Student> students = CsvReader.ReadStudents(filePath);
        //Console.WriteLine("Student Records");

        //foreach (Student student in students)
        //{
        //    Console.WriteLine(student);
        //}

        //Problem 2
        string filePath = @"D:\C# All Repo\C_Sharp_IO_Stream\CSV\Employee\employees.csv";
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "HR", Salary = 45000 },
            new Employee { Id = 2, Name = "Neha", Department = "IT", Salary = 65000 },
            new Employee { Id = 3, Name = "Rohit", Department = "Finance", Salary = 55000 },
            new Employee { Id = 4, Name = "Pooja", Department = "Marketing", Salary = 50000 },
            new Employee { Id = 5, Name = "Karan", Department = "Sales", Salary = 48000 }
        };
        CsvWriter.WriteEmployees(filePath, employees);

        Console.WriteLine("Employee data written to CSV file successfully.");

        Console.ReadKey();
    }
}
