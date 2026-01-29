using Newtonsoft.Json.Linq;
namespace JSONHandling;

public class JsonKeyValueReader
{
    public static void ReadAllKeysValues()
    {
        string json = @"{ 'name':'Amit', 'age':28, 'city':'Delhi' }";
        JObject obj = JObject.Parse(json);

        Console.WriteLine("\nJSON Keys & Values:");
        foreach (var item in obj)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
