using System.Collections.Generic;
using System.IO;
using System.Text;
namespace IPLAnalyzer;

public class CsvIplProcessor
{
    public static void ProcessCsv(string inputPath, string outputPath)
    {
        var lines = File.ReadAllLines(inputPath);
        var output = new StringBuilder();

        // write header
        output.AppendLine(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            // 🔹 skip empty or broken lines
            if (string.IsNullOrWhiteSpace(lines[i]))
                continue;

            var cols = lines[i].Split(',');

            // 🔹 SAFETY CHECK (THIS FIXES THE EXCEPTION)
            if (cols.Length < 7)
            {
                // merge with next line if broken
                if (i + 1 < lines.Length)
                {
                    lines[i] = lines[i] + " " + lines[i + 1];
                    i++; // skip next line
                    cols = lines[i - 1].Split(',');
                }
            }

            // 🔹 final guard
            if (cols.Length < 7)
                continue;

            // apply censorship
            cols[1] = CensorshipService.MaskTeamName(cols[1]);
            cols[2] = CensorshipService.MaskTeamName(cols[2]);
            cols[5] = CensorshipService.MaskTeamName(cols[5]);
            cols[6] = CensorshipService.RedactPlayer();

            output.AppendLine(string.Join(",", cols));
        }

        File.WriteAllText(outputPath, output.ToString());
    }
}
