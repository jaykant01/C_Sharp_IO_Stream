namespace Streams;

public class WordCounter
{
    public static void CountWords(string sourcePath)
    {
        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(sourcePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split line into words
                    string[] words = line
                        .ToLower()
                        .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            Console.WriteLine("Top 5 most frequent words:\n");

            var topWords = wordCount
                .OrderByDescending(w => w.Value)
                .Take(5);

            foreach (var item in topWords)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
