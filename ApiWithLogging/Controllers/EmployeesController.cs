using ApiWithLogging.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithLogging.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private static readonly IReadOnlyList<Employee> Items = new List<Employee>()
    {
        new() {
            Id = 1,
            Name = "abc",
        },
        new() {
            Id = 2,
            Name = "bcd",
        },
    };

    [HttpGet]
    public IEnumerable<Employee> GetItems()
    {
        return Items.ToList();
    }

    [HttpGet("{id}")]
    public Employee GetItem(int id)
    {
        return Items.Single(x => x.Id == id);
    }
}
