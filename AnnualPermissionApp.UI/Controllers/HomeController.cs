using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PermissionApp.AnnualPermissionApp.UI.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles="Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}