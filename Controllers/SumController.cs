using Microsoft.AspNetCore.Mvc;

namespace PraceticeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    [HttpPost]
    public int Post(SumRequest request)
    {
        return request.FirstNumber + request.SecondNumber;
    }
}

public class SumRequest
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
}
