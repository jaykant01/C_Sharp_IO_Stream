using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;
namespace Streams;

public class PipeStream
{
    public static void Start()
    {
        try
        {
            using (AnonymousPipeServerStream server =
                   new AnonymousPipeServerStream(PipeDirection.Out))
            using (AnonymousPipeClientStream client =
                   new AnonymousPipeClientStream(PipeDirection.In,
                   server.GetClientHandleAsString()))
            {
                Thread writerThread = new Thread(() => Writer(server));
                Thread readerThread = new Thread(() => Reader(client));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Pipe error: " + ex.Message);
        }
    }

    private static void Writer(System.IO.Pipes.PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe))
            {
                writer.AutoFlush = true;

                for (int i = 1; i <= 5; i++)
                {
                    string msg = $"Message {i} from Writer";
                    Console.WriteLine("Writing: " + msg);
                    writer.WriteLine(msg);
                    Thread.Sleep(500);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer error: " + ex.Message);
        }
    }

    private static void Reader(System.IO.Pipes.PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Read: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader error: " + ex.Message);
        }
    }
}
