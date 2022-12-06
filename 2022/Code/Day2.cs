namespace Code;

public class Day2
{
    public static int partA(string data)
    {
        var lines = data.Split('\n', StringSplitOptions.TrimEntries);
        var dict = new Dictionary<string, int>(){
            {"A", 1},
            {"B", 2},
            {"C", 3},
            {"X", 1},
            {"Y", 2},
            {"Z", 3}
        };

        var score = 0;
        foreach (var item in lines)
        {
            if (string.IsNullOrEmpty(item))
                continue;

            var chars = item.Split(' ');
            if (dict[chars[0]] < dict[chars[1]])
                score += dict[chars[1]] + 6;
            else if (dict[chars[0]] > dict[chars[1]])
                score += dict[chars[1]] + 0;
            else
                score += dict[chars[1]] + 3;

        }
        return score;
    }
}
