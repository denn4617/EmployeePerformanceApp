using EmployeePerformanceApp.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeePerformanceApp.Server.Services
{
    public interface IEmployeeTaskService
    {
        Task<IEnumerable<EmployeeTask>> GetAllTasksAsync();
        Task<EmployeeTask> GetTaskByIdAsync(int id);
        Task<EmployeeTask> CreateTaskAsync(EmployeeTask task);
        Task<EmployeeTask> UpdateTaskAsync(EmployeeTask task);
        Task<bool> DeleteTaskAsync(int id);
    }
}
