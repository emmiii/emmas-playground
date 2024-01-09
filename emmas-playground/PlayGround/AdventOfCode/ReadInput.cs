namespace AdventOfCode;
public class ReadInput
{
    public static IEnumerable<T> ReadPuzzleInputByLines<T>(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        return lines.Select(x => (T)Convert.ChangeType(x.Trim(), typeof(T)));
    }
    
    public static List<string> ReadPuzzleInTwoLines(string filePath)
    {
        return File.ReadAllLines(filePath).ToList();
    }


    public static IEnumerable<T> ReadCommaSeparatedPuzzleInput<T>(string filePath)
    {
        var parts = File.ReadAllText(filePath).Split(',');
        return parts.Select(x => (T)Convert.ChangeType(x.Trim(), typeof(T)));
    }
}

