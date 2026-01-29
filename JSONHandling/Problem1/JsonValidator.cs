using Newtonsoft.Json.Linq;

namespace JSONHandling;

public class JsonValidator
{
    public static void ValidateJson()
    {
        string jsonData = @"{ 'name': 'Rohit', 'age': 30 }";

        JObject obj = JObject.Parse(jsonData);

        bool isValid =
            obj["name"] != null &&
            obj["age"] != null &&
            obj["age"].Type == JTokenType.Integer;

        Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
    }
}
