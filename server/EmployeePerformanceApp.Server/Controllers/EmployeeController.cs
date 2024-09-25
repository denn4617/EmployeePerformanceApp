using Microsoft.AspNetCore.Mvc;
using EmployeePerformanceApp.Server.Models; 
using EmployeePerformanceApp.Server.Services; 
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    // Placeholder for API methods (CRUD)
}