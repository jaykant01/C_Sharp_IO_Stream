namespace JSONHandling;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //StudentJson.CreateStudentJson();
        //CarJson.ConvertCarToJson();
        //JsonFileReader.ReadSpecificFields();
        //JsonMerger.MergeJsonObjects();
        //JsonValidator.ValidateJson();
        //JsonArrayConverter.ConvertListToJsonArray();
        //JsonFilter.FilterAgeGreaterThan25();



        //Problem 2
        JsonKeyValueReader.ReadAllKeysValues();
        JsonListToArray.Convert();
        JsonAgeFilter.Filter();
        JsonEmailValidator.ValidateEmail();
        JsonFileMerger.MergeFiles();
        JsonToXmlConverter.Convert();
        CsvToJsonConverter.Convert();
        JsonReportGenerator.Generate();

        Console.ReadKey();
    }
}
