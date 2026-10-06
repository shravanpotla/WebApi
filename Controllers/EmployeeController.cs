using Microsoft.AspNetCore.Mvc;
namespace PraceticeApi.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public Employee Post(Getid request)
    {
        if (request.Id == 101)
        {
            return new Employee{Id=101,Name="Rahul",Department="IT"};
        }
        else
        {
            return new Employee{Id=0,Name="Not Found",Department="No Dept"};
        }
    }
}

public record Getid(int Id);
public class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Department{get;set;}

}