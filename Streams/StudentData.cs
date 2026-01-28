using System.IO;
namespace Streams;

public class StudentData
{
    public static void WriteStudentData(string destinationPath, int rollNo, string name, double gpa)
    {
        try
        {
            using (FileStream fs = new FileStream(destinationPath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(rollNo);
                writer.Write(name);
                writer.Write(gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error while writing data: " + ex.Message);
        }
    }

    public static void ReadStudentData(string destinationPath)
    {
        try
        {
            using (FileStream fs = new FileStream(destinationPath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine("Student Details Retrieved:");
                Console.WriteLine($"Roll No : {rollNo}");
                Console.WriteLine($"Name    : {name}");
                Console.WriteLine($"GPA     : {gpa}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error while reading data: " + ex.Message);
        }
    }
}
