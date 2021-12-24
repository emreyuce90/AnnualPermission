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
        public async Task<IActionResult> Login(AppUserLoginDto model)
        {
            //check model is correct
            if (ModelState.IsValid)
            {
                //Check user is exist
                var loggingUser = await _userManager.FindByNameAsync(model.Username);
                if (loggingUser != null)
                {
                    //password kontrol
                    var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        //rollere göre yönlendirme yap
                        var roleList = await _userManager.GetRolesAsync(loggingUser);
                        if (roleList.Contains("Admin"))
                        {
                            return RedirectToAction("Index","Employee",new {area ="Admin"});
                        }
                        else
                        {
                            return RedirectToAction("GetPermissionList","Permission",new { area="Member", Id = loggingUser.Id});
                        }
                    }

                }
                ModelState.AddModelError("","Girmiş olduğunuz şifre veya kullanıcı adı hatalı");
                return View(model);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }



    }
}