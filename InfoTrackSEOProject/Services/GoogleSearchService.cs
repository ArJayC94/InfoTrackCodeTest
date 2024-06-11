public class GoogleSearchService : IGoogleSearchService
{
    private readonly HttpClient _httpClient;
    private readonly IParser _parser;

    public GoogleSearchService(HttpClient httpClient, IParser parser)
    {
        this._httpClient = httpClient;
        this._parser = parser;
    }

    public async Task<string> GetPositionOfAppeared(string keyword, string url)
    {
        var response = await this._httpClient.GetStringAsync($"https://www.google.co.uk/search?num=100&q={keyword}");
        var positions = this._parser.ParsePositions(response, url);

        return positions.Count > 0 ? string.Join(", ", positions) : "0";
    }
}
