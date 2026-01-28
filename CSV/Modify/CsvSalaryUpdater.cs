namespace CSV;

public class CsvSalaryUpdater
{
    public static void UpdateSalary(string inputFile, string outputFile)
    {
        List<Employee> employees = new List<Employee>();

        // READ CSV
        using (StreamReader reader = new StreamReader(inputFile))
        {
            string line;

            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                Employee emp = new Employee
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3])
                };

                // Increase salary by 10% for IT department
                if (emp.Department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    emp.Salary += emp.Salary * 0.10;
                }

                employees.Add(emp);
            }
        }

        // WRITE UPDATED CSV
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine("ID,Name,Department,Salary");

            foreach (Employee emp in employees)
            {
                writer.WriteLine(emp.ToString());
            }
        }
    }
}
