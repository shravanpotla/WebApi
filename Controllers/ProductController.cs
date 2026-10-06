using Microsoft.AspNetCore.Mvc;
namespace PraceticeApi.Controllers;

public class Product
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Brand{get;set;}
    public int price{get;set;}

}
[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Get()
    {
        return new Product
        {
            Id=1,
            Name="Laptop",
            Brand="Dell",
            price=75000
        };
    }
}
