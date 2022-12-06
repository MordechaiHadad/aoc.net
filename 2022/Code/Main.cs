namespace Code;

public class Day1
{
    public static int partA(string data)
    {
        var biggest = 0;
        var newData = transformData(data);

        foreach (var item in newData)
        {
            if (item > biggest)
                biggest = item;

        }

        return biggest;
    }

    public static int partB(string data)
    {
        var newData = transformData(data);
        Array.Sort(newData);
        Array.Reverse(newData);

        var sum = newData.Take(3).Sum();
        return sum;
    }

    protected static int[] transformData(string data)
    {
        var current = 0;
        var list = new List<int>();

        var lines = data.Split('\n', StringSplitOptions.TrimEntries);
        foreach (var item in lines)
        {
            var number = 0;
            if (!string.IsNullOrEmpty(item))
            {
                if (int.TryParse(item, out number))
                    current += number;

                if (item == lines.Last())
                    list.Add(current);
            }
            else
            {
                list.Add(current);
                current = 0;
            }
        }
        return list.ToArray();
    }
}
