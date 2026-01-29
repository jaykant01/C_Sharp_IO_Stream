using Newtonsoft.Json;
using System.Collections.Generic;
namespace JSONHandling;

public class JsonArrayConverter
{
    public static void ConvertListToJsonArray()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Ankit", Age = 26 },
            new Employee { Name = "Priya", Age = 24 }
        };

        string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine("\nJSON Array:\n" + json);
    }
}
