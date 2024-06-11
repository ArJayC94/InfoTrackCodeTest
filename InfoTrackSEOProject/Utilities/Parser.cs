
using System.Text.RegularExpressions;

public class Parser : IParser
{

    public List<int> ParsePositions(string response, string url)
    {
        string pattern = @"<div class=""egMi0 kCrYT"">\s*<a\s+href=""([^""]+)"".*?>";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(response);

        var positions = matches
                 .Cast<Match>()
                 .Select((node, index) => new { Html = node.Groups[1].Value, Index = index + 1 })
                 .Select(x => new { x.Index, Url = ExtractUrl(System.Net.WebUtility.HtmlDecode(x.Html)) })
                 .Where(x => x.Url.Contains(url))
                 .Select(x => x.Index)
                 .ToList();

        return positions;
    }

    private string ExtractUrl(string url)
    {
        if (url.StartsWith("/url?q="))
        {
            url = url.Substring(7);
        }
        int ampIndex = url.IndexOf('&');

        if (ampIndex != -1)
        {
            url = url.Substring(0, ampIndex);
        }

        return url;
    }
}
