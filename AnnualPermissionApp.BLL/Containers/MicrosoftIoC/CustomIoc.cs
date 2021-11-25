using annualPermissions.PermissionApp.AnnualPermissionApp.BLL.ValidationRules.FluentValidation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PermissionApp.AnnualPermissionApp.BLL.Concrete;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos;

namespace PermissionApp.AnnualPermissionApp.BLL.Containers.MicrosoftIoC
{
    public static class CustomIoc
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<PermissionAppContext>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            //AppUser
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            //Employee
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeRepository>();

            //Permission

            services.AddScoped<IPermissionService, PermissionManager>();
            services.AddScoped<IPermissionDal, EfPermissionRepository>();

            services.AddTransient<IValidator<EmployeeAddDto>,EmployeeAddDtoValidator>();
            services.AddTransient<IValidator<EmployeeUpdateDto>,EmployeeUpdateDtoValidator>();
            

        }
    }
}