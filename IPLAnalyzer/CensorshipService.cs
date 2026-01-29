namespace IPLAnalyzer;

public class CensorshipService
{
    public static string MaskTeamName(string team)
    {
        if (string.IsNullOrEmpty(team)) return team;

        string[] parts = team.Split(' ');

        if (parts.Length >= 2)
        {
            parts[1] = "***";
        }

        return string.Join(" ", parts);
    }

    public static string RedactPlayer()
    {
        return "REDACTED";
    }
}
