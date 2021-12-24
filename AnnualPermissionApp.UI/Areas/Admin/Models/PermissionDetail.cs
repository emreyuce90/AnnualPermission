namespace AnnualPermissionApp.UI.Areas.Admin.Models
{
    public class PermissionDetail
    {
        public int ThisYear { get; set; }
        public int LastYear { get; set; }
        public int LastPermission { get; set; }
        public int ThisPermission { get; set; }

        public int RemainsLastYear { get; set; }
        public int RemainsThisYear { get; set; }

        public int TotalRemains { get; set; }
    }
}

//  //Bu yıl kullandığı izinler
//             int thisYear = _permissionService.CountThisYearPermissions(id).Result;
//             //Geçen yıl kullandığı izinler
//             int lastYear = _permissionService.CountLastYearPermissions(id).Result;
//             //geçen yıl izin hakkı
//             int lastPermission = _employeeService.PermissionRightLastYear(id).Result;
//             //bu yıl izin hakkı
//             int thisPermission = _employeeService.PermissionRightThisYear(id).Result;
//             //Geçen yıldan kalan izni
//             int remainsLastYear = lastPermission-lastYear;
//             //Bu yıldan kalan izni
//             int remainsThisYear = thisPermission-thisYear;
//             //Toplam kalan izin
//             int totalRemains =remainsLastYear -remainsThisYear;