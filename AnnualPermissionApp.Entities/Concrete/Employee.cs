using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.Entities.Concrete
{
    public class Employee:ITable
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name  { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime  EnterDate { get; set; }
        
        public List<Permission> Permissions { get; set; }

    }
}