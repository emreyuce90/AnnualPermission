using System;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.Entities.Concrete
{
    public class Permission : ITable
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestPicturePath { get; set; }
        public int DaysCount { get; set; }
        public string Description { get; set; }

    }
}