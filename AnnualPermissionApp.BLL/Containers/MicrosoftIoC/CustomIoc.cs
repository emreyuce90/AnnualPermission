
using AnnualPermissionApp.BLL.Validators.FluentValidation;
using AnnualPermissionApp.DTO;
using AnnualPermissionApp.Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PermissionApp.AnnualPermissionApp.BLL.Concrete;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Containers.MicrosoftIoC
{
    public static class CustomIoc
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidator<EmployeeAddDto>, EmployeeAddValidator>();
            services.AddTransient<IValidator<AppUserRegisterDto>, AppUserRegisterValidator>();


            services.AddDbContext<PermissionAppContext>(options => options.UseLazyLoadingProxies());
            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<PermissionAppContext>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            //AppUser
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            //Employee
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            //Permission

            services.AddScoped<IPermissionService, PermissionManager>();
            services.AddScoped<IPermissionDal, EfPermissionRepository>();




        }
    }
}