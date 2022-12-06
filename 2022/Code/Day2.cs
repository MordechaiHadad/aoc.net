namespace Code;

public class Day2
{
    public static int partA(string data)
    {
        var lines = data.Split('\n', StringSplitOptions.TrimEntries);
        var dict = new Dictionary<string, int>(){
            {"A X", 4},
            {"A Y", 8},
            {"A Z", 3},
            {"B X", 1},
            {"B Y", 5},
            {"B Z", 9},
            {"C X", 7},
            {"C Y", 2},
            {"C Z", 6}
        };

        var score = 0;
        foreach (var item in lines)
        {
            if (string.IsNullOrEmpty(item))
                continue;

            score += dict[item];

        }
        return score;
    }
}
