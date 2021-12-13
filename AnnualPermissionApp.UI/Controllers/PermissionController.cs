using AnnualPermissionApp.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
    public class PermissionController : Controller
    {
        public IActionResult AddPermission()
        {
            return View(new PermissionAddModel());
        }
    }
}