using AutoMapper;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;
using PermissionApp.AnnualPermissionApp.UI.Models;

namespace PermissionApp.AnnualPermissionApp.UI.AutoMapper
{
    public class CustomMapper : Profile
    {
        public CustomMapper()
        {
            //Employee
            CreateMap<Employee,EmployeeViewModel>();
            CreateMap<EmployeeViewModel,Employee>();

        }
    }
}