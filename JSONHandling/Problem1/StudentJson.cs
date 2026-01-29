using Newtonsoft.Json;
namespace JSONHandling;

public class StudentJson
{
    public static void CreateStudentJson()
    {
        var student = new
        {
            name = "Rahul",
            age = 21,
            subjects = new[] { "Math", "Physics", "CS" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("\nStudent JSON:\n" + json);
    }
}
