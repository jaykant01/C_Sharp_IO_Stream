using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace JSONHandling;

public class JsonReportGenerator
{
    public static void Generate()
    {
        var records = new List<object>
        {
            new { Id = 1, Name = "Anil", Salary = 50000 },
            new { Id = 2, Name = "Sunita", Salary = 65000 }
        };

        string report = JsonConvert.SerializeObject(records, Formatting.Indented);
        Console.WriteLine("\nJSON Report:\n" + report);
    }
}
