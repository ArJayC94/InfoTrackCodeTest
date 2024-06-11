public interface IGoogleSearchService
{
    Task<string> GetPositionOfAppeared(string keyword, string url);

}
