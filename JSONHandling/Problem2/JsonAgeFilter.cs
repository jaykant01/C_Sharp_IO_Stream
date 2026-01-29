using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace JSONHandling;

public class JsonAgeFilter
{
    public static void Filter()
    {
        string json = @"[
            { 'name':'A', 'age':23 },
            { 'name':'B', 'age':29 },
            { 'name':'C', 'age':31 }
        ]";

        JArray array = JArray.Parse(json);

        Console.WriteLine("\nUsers age > 25:");
        foreach (var user in array.Where(x => (int)x["age"] > 25))
        {
            Console.WriteLine(user["name"]);
        }
    }
}
