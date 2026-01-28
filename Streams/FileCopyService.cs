using System.IO;
namespace Streams;

public class FileCopyService
{
    public void CopyFile(string sourcePath, string destinationPath)
    {
        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source File does not exist.");
                return;

            }

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))

            using (FileStream fsWrite = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))

            {
                int byteData;
                while((byteData = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)byteData);
                }
            }

            Console.WriteLine("File Copied Successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O error occurred");
            Console.WriteLine(ex.Message);
        }
               
    }
}
