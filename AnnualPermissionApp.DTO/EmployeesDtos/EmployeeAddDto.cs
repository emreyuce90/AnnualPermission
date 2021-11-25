using System;

namespace PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos{
    public class EmployeeAddDto
    {
        
        public string Name  { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime  EnterDate { get; set; }

    }
}