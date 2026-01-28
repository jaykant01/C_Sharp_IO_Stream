namespace CSV;

public class CsvWriter
{
    public static void WriteEmployees(string filePath, List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Department,Salary");

            foreach (Employee emp in employees)
            {
                writer.WriteLine(emp.ToString());
            }
        }
    }
}
