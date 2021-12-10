using System;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.Entities.Concrete
{
    public class Permission : ITable
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestPicturePath { get; set; }
        public int DaysCount { get; set; }
        public string Description { get; set; }

    }
}