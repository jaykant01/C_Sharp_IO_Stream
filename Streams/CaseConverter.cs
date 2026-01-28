using System.IO;
using System.Text;
namespace Streams;

public class CaseConverter
{
    public static void ConvertUpperToLower(string sourcePath, string destinationPath)
    {
        try
        {
            Encoding encoding = Encoding.UTF8;

            using (FileStream inputFs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInput = new BufferedStream(inputFs))
            using (StreamReader reader = new StreamReader(bufferedInput, encoding))

            using (FileStream outputFs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutput = new BufferedStream(outputFs))
            using (StreamWriter writer = new StreamWriter(bufferedOutput, encoding))
            {
                int ch;
                while ((ch = reader.Read()) != -1)
                {
                    char convertedChar = char.ToLower((char)ch);
                    writer.Write(convertedChar);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Permission Error: " + ex.Message);
        }
    }
}
