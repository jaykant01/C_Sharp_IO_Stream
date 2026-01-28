using System.Collections.Generic;
namespace Streams;

class Program
{
    static void Main(string[] args)
    {
        // File Copy 
        string sourcePath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\input.txt";
        string destinationPath = @"D:\\C# All Repo\\C_Sharp_IO_Stream\\Streams\\output.txt";
        //FileCopyService fileCopy = new FileCopyService();
        //fileCopy.CopyFile(sourcePath,destinationPath);


        // 100mb File Copy
        //string source = @"D:\C# All Repo\C_Sharp_IO_Stream\Streams\100mb.txt";
        //string destin = @"D:\C# All Repo\C_Sharp_IO_Stream\Streams\100mbOutput.txt";

        //LargeFileCopy largefile = new LargeFileCopy();
        //largefile.CopyFile(source,destin);


        // Input from Console and Output to file
        //ReadConsole readCs = new ReadConsole();
        //readCs.SaveUserInfo(destinationPath);


        // Problem $ Searializer
        //EmployeeSerializer serializer = new EmployeeSerializer();

        //// Create employee list
        //List<Employee> employees = new List<Employee>
        //    {
        //        new Employee(1, "Jaykant", "IT", 50000),
        //        new Employee(2, "Amit", "HR", 40000),
        //        new Employee(3, "Neha", "Finance", 60000)
        //    };

        //// Serialize employees
        //serializer.SaveEmployees(employees);

        //// Deserialize employees
        //List<Employee> loadedEmployees = serializer.LoadEmployees();

        //Console.WriteLine("\nEmployee Details:");
        //foreach (Employee emp in loadedEmployees)
        //{
        //    Console.WriteLine(
        //        $"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
        //}

        // Problem ByteArray Stream - Convert Image to ByteArray
        //string sourceImage = @"D:\C# All Repo\C_Sharp_IO_Stream\Streams\original.jpg";
        //string newImage = "copy.jpg";

        //byte[] imageBytes = ConvertImage.ImageToByteArray(sourceImage);

        //if (imageBytes == null)
        //{
        //    Console.WriteLine("Image conversion failed.");
        //    return;
        //}
        //ConvertImage.ByteArrayToImage(imageBytes, newImage);

        //bool isSame = ConvertImage.AreImagesIdentical(sourceImage, newImage);

        //Console.WriteLine(isSame ? "Images are identical" : "Images are NOT identical");


        // Filter Streams - Convert Uppercase to Lowercase
        Console.WriteLine("Converting uppercase text to lowercase");
        CaseConverter.ConvertUpperToLower(sourcePath, destinationPath);
        Console.WriteLine("Conversion completed successfully");

        Console.ReadKey();
    }
}
