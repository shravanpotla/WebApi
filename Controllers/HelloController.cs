using Microsoft.AspNetCore.Mvc;

namespace PracticeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        return "Hello, welcome to ASP.NET Core Web API!";
    }
}
