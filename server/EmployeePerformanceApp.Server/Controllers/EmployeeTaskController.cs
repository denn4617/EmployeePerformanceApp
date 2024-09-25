using Microsoft.AspNetCore.Mvc;
using EmployeePerformanceApp.Server.Models;
using EmployeePerformanceApp.Server.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class EmployeeTaskController : ControllerBase
{
    private readonly IEmployeeTaskService _employeeTaskService;

    public EmployeeTaskController(IEmployeeTaskService employeeTaskService)
    {
        _employeeTaskService = employeeTaskService;
    }

    // Placeholder for API methods (CRUD)
}
