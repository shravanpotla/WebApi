using Microsoft.AspNetCore.Mvc;
namespace PracticeApi.Controllers;

[ApiController]
[Route("[controller]")]

public class LanguageController : ControllerBase
{
    [HttpGet]
    public string[] Get()
    {
        return new string []{
                "C#",
                "Java",
                "Python",
                "JavaScript",
                "Go"
        };
    }

}