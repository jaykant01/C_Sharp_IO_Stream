using System.IO;
using System.Diagnostics;
namespace Streams;

public class LargeFileCopy
{
    private const int BufferSize = 4096;

    public void CopyFile(string source, string destin)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destin, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead, BufferSize))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite, BufferSize))
        {
            byte[] buffer = new byte[BufferSize];
            int bytesRead;

            while((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"BufferedStream Time: {stopwatch.ElapsedMilliseconds} ms");
    }
}
