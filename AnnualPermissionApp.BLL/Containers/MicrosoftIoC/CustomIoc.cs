
using AnnualPermissionApp.BLL.Validators.FluentValidation;
using AnnualPermissionApp.DTO;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PermissionApp.AnnualPermissionApp.BLL.Concrete;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;


namespace PermissionApp.AnnualPermissionApp.BLL.Containers.MicrosoftIoC
{
    public static class CustomIoc
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidator<EmployeeAddDto>, EmployeeAddValidator>();

            services.AddDbContext<PermissionAppContext>(options => options.UseLazyLoadingProxies());
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