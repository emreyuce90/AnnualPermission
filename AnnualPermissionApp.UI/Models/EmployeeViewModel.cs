using System;

namespace PermissionApp.AnnualPermissionApp.UI.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime EnterDate { get; set; }
    }
}