using Newtonsoft.Json.Linq;
namespace JSONHandling;

public class JsonMerger
{
    public static void MergeJsonObjects()
    {
        JObject json1 = JObject.Parse(@"{ 'name': 'Jay', 'age': 25 }");
        JObject json2 = JObject.Parse(@"{ 'email': 'jay@gmail.com' }");

        json1.Merge(json2);
        Console.WriteLine("\nMerged JSON:\n" + json1);
    }
}
