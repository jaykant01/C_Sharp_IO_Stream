namespace Streams;

public class ConvertImage
{
    public static byte[] ImageToByteArray(string imagePath)
    {
        try
        {
            return File.ReadAllBytes(imagePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error while reading image: " + ex.Message);
            return null;
        }
    }

    public static void ByteArrayToImage(byte[] imageBytes, string outputPath)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(outputPath, ms.ToArray());
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error while writing image: " + ex.Message);
        }
    }


    public static bool AreImagesIdentical(string image1, string image2)
    {
        byte[] file1Bytes = File.ReadAllBytes(image1);
        byte[] file2Bytes = File.ReadAllBytes(image2);

        if (file1Bytes.Length != file2Bytes.Length)
            return false;

        for (int i = 0; i < file1Bytes.Length; i++)
        {
            if (file1Bytes[i] != file2Bytes[i])
                return false;
        }
        return true;
    }
}
