namespace Streams;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\input.txt";
        string destinationPath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\output.txt";
        FileCopyService fileCopy = new FileCopyService();
        fileCopy.CopyFile(sourcePath,destinationPath);

        Console.ReadKey();
    }
}
