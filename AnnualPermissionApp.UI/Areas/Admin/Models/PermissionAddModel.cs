using System;
using Microsoft.AspNetCore.Http;

namespace AnnualPermissionApp.UI.Areas.Admin.Models
{
    public class PermissionAddModel
    {
        public int AppUserId { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public string RequestPicturePath { get; set; }
        public IFormFile Image { get; set; }
        public int DaysCount { get; set; }
        public string Description { get; set; }
    }
}