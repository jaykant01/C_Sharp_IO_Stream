using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace JSONHandling;

public class CsvToJsonConverter
{
    public static void Convert()
    {
        string[] csvLines =
        {
            "Name,Age",
            "Ravi,24",
            "Kiran,30"
        };

        var list = new List<Dictionary<string, string>>();

        for (int i = 1; i < csvLines.Length; i++)
        {
            var values = csvLines[i].Split(',');
            list.Add(new Dictionary<string, string>
            {
                { "Name", values[0] },
                { "Age", values[1] }
            });
        }

        string json = JsonConvert.SerializeObject(list, Formatting.Indented);
        Console.WriteLine("\nCSV to JSON:\n" + json);
    }
}
