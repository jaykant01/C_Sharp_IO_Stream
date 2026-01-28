using System.IO;
namespace Streams;

public class ReadConsole
{
    public void SaveUserInfo(string destinationPath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            {
                Console.Write("Enter your Name");
                string name = reader.ReadLine();

                Console.Write("Enter your Age");
                string age = reader.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter(destinationPath))
                {
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Language: " + language);
                }
            }
            Console.WriteLine("User information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O error occurred:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
