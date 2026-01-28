namespace Streams;

class Program
{
    static void Main(string[] args)
    {
        // File Copy 
        //string sourcePath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\input.txt";
        //string destinationPath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\output.txt";
        //FileCopyService fileCopy = new FileCopyService();
        //fileCopy.CopyFile(sourcePath,destinationPath);

        // 100mb File Copy
        string source = @"D:\C# All Repo\C_Sharp_IO_Stream\Streams\100mb.txt";
        string destin = @"D:\C# All Repo\C_Sharp_IO_Stream\Streams\100mbOutput.txt";

        LargeFileCopy largefile = new LargeFileCopy();
        largefile.CopyFile(source,destin);

        Console.ReadKey();
    }
}
