using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Streams;

public class EmployeeSerializer
{
    private string filePath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\employees.json";

    // Serialize list of employees
    public void SaveEmployees(List<Employee> employees)
    {
        try
        {
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);

            Console.WriteLine("Employees saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while saving employees:");
            Console.WriteLine(ex.Message);
        }
    }

    // Deserialize list of employees
    public List<Employee> LoadEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Employee file not found.");
                return new List<Employee>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while loading employees:");
            Console.WriteLine(ex.Message);
            return new List<Employee>();
        }
    }
}

