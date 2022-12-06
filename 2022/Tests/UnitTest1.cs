namespace Tests;
using Code;
using AocData;
using Newtonsoft.Json;

public class Config
{
    [JsonProperty]
    public string Key { get; set; }
}

public class Tests
{

    private Client _client;

    [SetUp]
    public void Setup()
    {
        var file = File.ReadAllText("../../../config.json");
        var result = JsonConvert.DeserializeObject<Config>(file);
        _client = new Client(result.Key);

    }

    [Test]
    public async Task Test1()
    {
        var testData = """
            1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000
            """;

        Assert.Multiple(() =>
        {
            Assert.AreEqual(24000, Day1.partA(testData));
            Assert.AreEqual(45000, Day1.partB(testData));
        });

        Console.WriteLine(Day1.partA(await _client.GetData(2022, 1)));
        Console.WriteLine(Day1.partB(await _client.GetData(2022, 1)));
    }
}
