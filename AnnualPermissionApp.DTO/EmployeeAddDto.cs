using System;

namespace AnnualPermissionApp.DTO{
    public class EmployeeAddDto{
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime EnterDate { get; set; }
    }
    
}