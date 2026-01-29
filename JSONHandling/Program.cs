namespace JSONHandling;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        StudentJson.CreateStudentJson();
        CarJson.ConvertCarToJson();
        JsonFileReader.ReadSpecificFields();
        JsonMerger.MergeJsonObjects();
        JsonValidator.ValidateJson();
        JsonArrayConverter.ConvertListToJsonArray();
        JsonFilter.FilterAgeGreaterThan25();


        Console.ReadKey();
    }
}
