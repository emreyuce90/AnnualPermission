using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
   
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            throw new Exception();
            return View();
        }
    }
}