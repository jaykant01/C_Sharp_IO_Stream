using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONHandling;

public class JsonFileReader
{
    public static void ReadSpecificFields()
    {
        string jsonText = @"{
            'name': 'Amit',
            'email': 'amit@gmail.com',
            'age': 28
        }";

        JObject obj = JObject.Parse(jsonText);
        Console.WriteLine($"\nName: {obj["name"]}, Email: {obj["email"]}");
    }
}
