using AnnualPermissionApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;

namespace AnnualPermissionApp.UI.ViewComponents
{
    public class PersonelViewComponent : ViewComponent
    {
        private readonly IAppUserService _employeeService;
        private readonly IPermissionService _permissionService;
        public PersonelViewComponent(IPermissionService permissionService,IAppUserService employeeService)
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
            //Geçen yıldan kalan izni
            int remainsLastYear = lastPermission-lastYear;
            //Bu yıldan kalan izni
            int remainsThisYear = thisPermission-thisYear;
            //Toplam kalan izin
            int totalRemains =remainsLastYear + remainsThisYear;
            //bir model oluşturup verileri model üzerinden view a aktaralım
            var detail = new PermissionDetail();
            detail.ThisYear = thisYear;
            detail.LastYear = lastYear;
            detail.LastPermission = lastPermission;
            detail.ThisPermission = thisPermission;
            detail.RemainsLastYear = remainsLastYear;
            detail.RemainsThisYear = remainsThisYear;
            detail.TotalRemains = totalRemains;
            return View(detail);
        }
    }
}