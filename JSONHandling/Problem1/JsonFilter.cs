using Newtonsoft.Json.Linq;
using System.Linq;
namespace JSONHandling;

public class JsonFilter
{
    public static void FilterAgeGreaterThan25()
    {
        string json = @"[
            { 'name': 'A', 'age': 22 },
            { 'name': 'B', 'age': 28 },
            { 'name': 'C', 'age': 30 }
        ]";

        JArray array = JArray.Parse(json);

        var filtered = array.Where(x => (int)x["age"] > 25);

        Console.WriteLine("\nAge > 25:");
        foreach (var item in filtered)
            Console.WriteLine(item["name"]);
    }
}
