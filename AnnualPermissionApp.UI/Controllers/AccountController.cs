using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new AppUserRegisterDto());
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser newUser = new AppUser();
                newUser.Name = model.Name;
                newUser.Surname = model.Surname;
                newUser.Title = model.Title;
                newUser.Email = model.EMail;
                newUser.EnterDate = model.EnterDate;
                newUser.UserName = model.Username;

                var result = await _userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    //Role ata
                    var roleResult = await _userManager.AddToRoleAsync(newUser, "Member");
                    if (roleResult.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    foreach (var error in roleResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new AppUserLoginDto());
        }

        [HttpPost]
        public IActionResult Login(AppUserLoginDto model)
        {
            //
            return View();
        }



    }
}