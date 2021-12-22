using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.Entities.Concrete{
    public class AppUser:IdentityUser<int>,ITable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    
        public string Title { get; set; }
        public DateTime  EnterDate { get; set; }
        public List<Permission> Permissions { get; set; }

    }
}