using System;

namespace EmployeePerformanceApp.Server.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime DateOfJoining { get; set; }
    }

}
