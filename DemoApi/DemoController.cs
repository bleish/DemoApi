using Microsoft.AspNetCore.Mvc;

namespace DemoApi;

public record Demo(string? Key1, string? Key2);

public record NestedDemo(string? Key1, Demo? Key2);

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    [HttpGet("fromDict")]
    public Dictionary<string, string> GetFromDict([FromQuery] Dictionary<string, string> demoQuery, [FromQuery] bool showAllResults)
    {
        return demoQuery;
    }
    
    [HttpGet("fromNestedDict")]
    public Dictionary<string, Dictionary<string, string>> GetFromDict([FromQuery] Dictionary<string, Dictionary<string, string>> demoQuery)
    {
        return demoQuery;
    }

    [HttpGet("fromObj")]
    public Demo GetFromObject([FromQuery] Demo demoQuery)
    {
        return demoQuery;
    }
    
    [HttpGet("fromNestedObj")]
    public NestedDemo GetFromObject([FromQuery] NestedDemo demoQuery)
    {
        return demoQuery;
    }
}