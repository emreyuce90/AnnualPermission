using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;

namespace AnnualPermissionApp.UI.ViewComponents
{
    public class PersonelViewComponent : ViewComponent
    {
        private readonly IEmployeeService _employeeService;
        private readonly IPermissionService _permissionService;
        public PersonelViewComponent(IPermissionService permissionService,IEmployeeService employeeService)
        {
            _permissionService = permissionService;
            _employeeService = employeeService;
        }
        public IViewComponentResult Invoke(int id)
        {        
            //Bu yıl kullandığı izinler
            int thisYear = _permissionService.CountThisYearPermissions(id).Result;
            //Geçen yıl kullandığı izinler
            int lastYear = _permissionService.CountLastYearPermissions(id).Result;
            //geçen yıl izin hakkı
            int lastPermission = _employeeService.PermissionRightLastYear(id).Result;
            //bu yıl izin hakkı
            int thisPermission = _employeeService.PermissionRightThisYear(id).Result;

            int remainsLastYear = lastPermission-lastYear;

            int remainsThisYear = thisPermission-thisYear;
            
            int totalRemains =remainsLastYear -remainsThisYear;

            return View();
        }
    }
}