using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
namespace IPLAnalyzer;

public class JsonIplProcessor
{
    public static void ProcessJson(string inputPath, string outputPath)
    {
        string json = File.ReadAllText(inputPath);
        var matches = JsonConvert.DeserializeObject<List<IplMatch>>(json);

        foreach (var match in matches)
        {
            string maskedTeam1 = CensorshipService.MaskTeamName(match.team1);
            string maskedTeam2 = CensorshipService.MaskTeamName(match.team2);

            var newScore = new Dictionary<string, int>();
            foreach (var entry in match.score)
            {
                newScore[CensorshipService.MaskTeamName(entry.Key)] = entry.Value;
            }

            match.team1 = maskedTeam1;
            match.team2 = maskedTeam2;
            match.score = newScore;
            match.winner = CensorshipService.MaskTeamName(match.winner);
            match.player_of_match = CensorshipService.RedactPlayer();
        }

        File.WriteAllText(
            outputPath,
            JsonConvert.SerializeObject(matches, Formatting.Indented)
        );
    }
}
