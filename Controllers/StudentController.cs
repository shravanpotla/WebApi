using Microsoft.AspNetCore.Mvc;
namespace PraceticeApi.Controllers;

public class Student
{
    public int Id {get; set;}
    public string Name{get; set;}
    public string Course{get;set;}
    public int age{get;set;}
}
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    [HttpGet]
    public Student Get()
    {
        return new Student
        {       
            Id = 101,
            Name = "Shravan",
            Course = "B.Tech",
            age = 22
        };
    }
}