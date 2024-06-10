using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

[Route("api/seochecker")]
public class SEOCheckerController : Controller
{
    private readonly IGoogleSearchService _searchService;

    public SEOCheckerController(IGoogleSearchService searchService)
    {
        this._searchService = searchService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string keyword, [FromQuery] string url)
    {
        try
        {
            var positions = await this._searchService.GetPositionOfAppeared(keyword, url);
            return Ok(positions);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"An error occurred: {ex.Message}");
            return BadRequest($"An error occurred while processing your request: {ex.Message}");
        }
    }
}


