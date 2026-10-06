using Microsoft.AspNetCore.Mvc;
namespace PraceticeApi.Controllers;

[ApiController]
[Route("[controller]")]

public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(Greet request)
    {
        return $"Hello {request.Name}";
    }
}
public sealed record Greet(string Name);
