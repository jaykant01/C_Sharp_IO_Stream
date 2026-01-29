namespace IPLAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        string jsonInput = @"D:\C# All Repo\C_Sharp_IO_Stream\IPLAnalyzer\ipl_input.json";
        string jsonOutput = @"D:\C# All Repo\C_Sharp_IO_Stream\IPLAnalyzer\ipl_censored.json";

        string csvInput = @"D:\C# All Repo\C_Sharp_IO_Stream\IPLAnalyzer\ipl_input.csv";
        string csvOutput = @"D:\C# All Repo\C_Sharp_IO_Stream\IPLAnalyzer\ipl_censored.csv";

        JsonIplProcessor.ProcessJson(jsonInput, jsonOutput);
        CsvIplProcessor.ProcessCsv(csvInput, csvOutput);

        Console.WriteLine("IPL Data Censorship Completed Successfully!");

        Console.ReadKey();
    }
}
