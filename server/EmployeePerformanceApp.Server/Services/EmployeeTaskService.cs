using EmployeePerformanceApp.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeePerformanceApp.Server.Services
{
    public class EmployeeTaskService : IEmployeeTaskService
    {
        private readonly AppDbContext _context;

        public EmployeeTaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeTask>> GetAllTasksAsync()
        {
            return await _context.EmployeeTasks
                                 .Include(t => t.Employee)
                                 .ToListAsync();
        }

        public async Task<EmployeeTask> GetTaskByIdAsync(int id)
        {
            return await _context.EmployeeTasks
                                 .Include(t => t.Employee)
                                 .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<EmployeeTask> CreateTaskAsync(EmployeeTask task)
        {
            _context.EmployeeTasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<EmployeeTask> UpdateTaskAsync(EmployeeTask task)
        {
            var existingTask = await _context.EmployeeTasks.FindAsync(task.Id);

            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.Deadline = task.Deadline;
                existingTask.EmployeeId = task.EmployeeId;

                await _context.SaveChangesAsync();
            }

            return existingTask;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.EmployeeTasks.FindAsync(id);
            if (task == null)
            {
                return false;
            }

            _context.EmployeeTasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
