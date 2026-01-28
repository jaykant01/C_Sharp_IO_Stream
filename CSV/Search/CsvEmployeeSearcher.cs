using System.IO;
namespace CSV1;

public class CsvEmployeeSearcher
{
    public static void SearchEmployeeByName(string filePath, string employeeName)
    {
        bool isFound = false;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                if (data[1].Equals(employeeName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Employee Found");
                    Console.WriteLine();
                    Console.WriteLine($"Department : {data[2]}");
                    Console.WriteLine($"Salary     : {data[3]}");

                    isFound = true;
                    break;
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
