using Microsoft.AspNetCore.Mvc;

namespace PermissionApp.AnnualPermissionApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}