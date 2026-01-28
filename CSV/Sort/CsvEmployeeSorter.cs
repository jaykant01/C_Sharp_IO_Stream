using System.Collections.Generic;
using System.IO;

namespace CSV3;

public class CsvEmployeeSorter
{
    public static List<Employee> ReadEmployees(string filePath)
    {
        List<Employee> employees = new List<Employee>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                // Validate column count
                if (data.Length < 4)
                    continue;

                // Safe parsing
                if (!int.TryParse(data[0], out int id))
                    continue;

                if (!double.TryParse(data[3], out double salary))
                    continue;

                employees.Add(new Employee
                {
                    Id = id,
                    Name = data[1],
                    Department = data[2],
                    Salary = salary
                });
            }
        }

        return employees;
    }

    public static void PrintTop5BySalary(List<Employee> employees)
    {
        employees.Sort((a, b) => b.Salary.CompareTo(a.Salary));

        Console.WriteLine("Top 5 Highest Paid Employees");
        Console.WriteLine();

        int limit = Math.Min(5, employees.Count);

        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
}
