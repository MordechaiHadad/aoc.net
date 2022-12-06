namespace AocData;

public class Client
{

    private HttpClient _client;
    public Client(string key)
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("Cookie", key);
    }

    public async Task<string> GetData(int year, int day)
    {
        var result = await _client.GetAsync($"https://adventofcode.com/{year}/day/{day}/input");

        if (!result.IsSuccessStatusCode)
            return string.Empty;

        return await result.Content.ReadAsStringAsync();
    }
}
