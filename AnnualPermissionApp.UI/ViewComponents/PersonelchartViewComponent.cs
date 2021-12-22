using System;
using AnnualPermissionApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;

namespace AnnualPermissionApp.UI.ViewComponents
{
    public class PersonelchartViewComponent : ViewComponent
    {
        private readonly IAppUserService _employeeService;
        private readonly IPermissionService _permissionService;
        public PersonelchartViewComponent(IPermissionService permissionService,IAppUserService employeeService)
        {
            _permissionService = permissionService;
            _employeeService = employeeService;
        }
        public IViewComponentResult Invoke(int id)
        {        
            //Bu yıl kullandığı izinler
            double thisYear = _permissionService.CountThisYearPermissions(id).Result;
            //Geçen yıl kullandığı izinler
            double lastYear = _permissionService.CountLastYearPermissions(id).Result;
            //geçen yıl izin hakkı
            double lastPermission = _employeeService.PermissionRightLastYear(id).Result;
            //bu yıl izin hakkı
            double thisPermission = _employeeService.PermissionRightThisYear(id).Result;
            //Geçen yıldan kalan izni
            double remainsLastYear = lastPermission-lastYear;
            //Bu yıldan kalan izni
            double remainsThisYear = thisPermission-thisYear;
            //Toplam kalan izin
            double totalRemains =remainsLastYear + remainsThisYear;
            //Toplam izinler / toplam izin hakkı
            double hakedis = lastYear+thisYear;
            double kullanilan =lastPermission + thisPermission;

            double result = Math.Round(((hakedis/kullanilan)*100),0);
            if(hakedis ==0 || kullanilan == 0)
            {
                ViewBag.Proportion =0;
            }
            else{
                ViewBag.Proportion = result;
            }
           
            
            
            return View();
        }
    }
}