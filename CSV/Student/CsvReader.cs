namespace CSV;

public class CsvReader
{
    public static List<Student> ReadStudents(string filePath)
    {
        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                Student student = new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = int.Parse(data[3])
                };

                students.Add(student);
            }
        }

        return students;
    }
}
