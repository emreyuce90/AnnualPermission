using System.Threading.Tasks;
using AnnualPermissionApp.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI
{
    public static class IdentityInitilazer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                var user = new AppUser()
                {
                    Name = "admin",
                    Email = "info@bayraktarlartrakya.com"
                };
                await userManager.CreateAsync(user, "Bayraktarlar123*");
                await userManager.AddToRoleAsync(user,"Admin");
            }

        }
    }
}