using System.Collections.Generic;
using Google.Protobuf;

namespace Supermarket.API.Domain.Models
{
    public class ControlEmployees
    {
        public int ControlEmployeesId { get; set; }
        public ProjectControl ProjectControl_Control { get; set; }
        
        public int ProjectControlId { get; set; }
        public Employees Employees_Cemployee { get; set; }
        
        public int EmployeeId { get; set; }
    }
}