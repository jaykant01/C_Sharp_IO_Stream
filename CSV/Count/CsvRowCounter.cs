namespace CSV;

public class CsvRowCounter
{
    public static int CountRows(string filePath)
    {
        int rowCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            reader.ReadLine();

            while (reader.ReadLine() != null)
            {
                rowCount++;
            }
        }

        return rowCount;
    }
}
