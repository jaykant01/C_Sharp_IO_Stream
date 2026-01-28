namespace CSV;

public class CsvStudentFilter
{
    public static void PrintStudentsWithMarksAbove80(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            reader.ReadLine();

            Console.WriteLine("Students Scoring More Than 80 Marks");
            Console.WriteLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                int marks = int.Parse(data[3]);

                if (marks > 80)
                {
                    Student student = new Student
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Age = int.Parse(data[2]),
                        Marks = marks
                    };

                    Console.WriteLine(student);
                }
            }
        }
    }
}
