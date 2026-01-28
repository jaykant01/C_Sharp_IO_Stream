using System.IO;
using System.Text.RegularExpressions;
namespace CSV;

public class CsvValidator
{
    // Email regex (simple & safe for exams)
    private static readonly Regex EmailRegex =
        new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    // Phone: exactly 10 digits
    private static readonly Regex PhoneRegex =
        new Regex(@"^\d{10}$");

    public static void ValidateCsv(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);

        reader.ReadLine();

        string line;
        int rowNumber = 1;

        while ((line = reader.ReadLine()) != null)
        {
            rowNumber++;

            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] data = line.Split(',');

            if (data.Length < 4)
            {
                PrintError(rowNumber, line, "Invalid column count");
                continue;
            }

            string email = data[2];
            string phone = data[3];

            bool emailValid = EmailRegex.IsMatch(email);
            bool phoneValid = PhoneRegex.IsMatch(phone);

            if (!emailValid || !phoneValid)
            {
                string errorMessage = "";

                if (!emailValid)
                    errorMessage += "Invalid Email format. ";

                if (!phoneValid)
                    errorMessage += "Phone number must be exactly 10 digits.";

                PrintError(rowNumber, line, errorMessage);
            }
        }
    }

    private static void PrintError(int row, string data, string message)
    {
        Console.WriteLine("Invalid Row Detected");
        Console.WriteLine($"Row Number : {row}");
        Console.WriteLine($"Data       : {data}");
        Console.WriteLine($"Error      : {message}");
        Console.WriteLine();
    }
}
