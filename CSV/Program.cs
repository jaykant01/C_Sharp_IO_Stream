namespace CSV;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"D:\C# All Repo\C_Sharp_IO_Stream\CSV\Student\students.csv";
        List<Student> students = CsvReader.ReadStudents(filePath);
        Console.WriteLine("Student Records");

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        Console.ReadKey();
    }
}
