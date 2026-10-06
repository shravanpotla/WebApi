using Microsoft.AspNetCore.Mvc;
namespace SquareController.Controllers;
[ApiController]
[Route("[controller]")]
public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(Square request)
    {
        return request.Side*request.Side;
    }
}
public class Square
{
    public int Side { get; set; }
}