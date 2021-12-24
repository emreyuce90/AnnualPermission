using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
    [Authorize(Roles="Admin")]
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}