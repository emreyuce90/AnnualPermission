using AnnualPermissionApp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new AppUserRegisterDto());
        }

        [HttpPost]
        public IActionResult Register(AppUserRegisterDto model)
        {
            if(ModelState.IsValid)
            {
                //
            }
           
            return View(model);
        }

    }
}