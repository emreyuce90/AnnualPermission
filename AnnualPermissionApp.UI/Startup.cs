using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnualPermissionApp.Entities.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PermissionApp.AnnualPermissionApp.BLL.Containers.MicrosoftIoC;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

          
            services.AddDependencies();
              // services.ConfigureApplicationCookie(opt =>
            // {
            //     opt.Cookie.Name = "Permission";
            //     opt.ExpireTimeSpan = TimeSpan.FromDays(20);
            //     opt.Cookie.HttpOnly = true;
            //     opt.Cookie.SameSite = SameSiteMode.Strict;
            //     opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
            //     opt.Cookie.Path = "/Account/Login";
            // });
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            
            
           app.UseExceptionHandler("/Error");
            //app.UseStatusCodePagesWithReExecute("/Errorstatus");
            //IdentityInitilazer.SeedData(userManager, roleManager).Wait();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(name:"areas",pattern:"{area}/{controller}/{action}/{id?}");
                endpoints.MapControllerRoute(name:"default",pattern:"{controller=Account}/{action=Login}/{id?}");
                
            });

        }
    }
}
