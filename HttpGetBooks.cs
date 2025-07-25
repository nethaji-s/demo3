using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Books.Function;

public class HttpGetBooks
{
    private readonly ILogger<HttpGetBooks> _logger;

    public HttpGetBooks(ILogger<HttpGetBooks> logger)
    {
        _logger = logger;
    }

    [Function("HttpGetBooks")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}