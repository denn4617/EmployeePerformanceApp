using System;

namespace EmployeePerformanceApp.Server.Models
{
    public class EmployeeTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int EmployeeId { get; set; }

        // Navigation property for the related Employee
        public Employee Employee { get; set; }
    }
}
