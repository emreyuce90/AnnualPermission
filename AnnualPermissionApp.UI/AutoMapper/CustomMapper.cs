using AnnualPermissionApp.DTO;
using AnnualPermissionApp.UI.Models;
using AutoMapper;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;


namespace PermissionApp.AnnualPermissionApp.UI.AutoMapper
{
    public class CustomMapper : Profile
    {
        public CustomMapper()
        {
            //Employee
            CreateMap<Employee,EmployeeListDto>();
            CreateMap<EmployeeListDto,Employee>();
            
            CreateMap<Employee,EmployeeAddDto>();
            CreateMap<EmployeeAddDto,Employee>();

            CreateMap<EmployeeUpdateDto,Employee>();
            CreateMap<Employee,EmployeeUpdateDto>();

            CreateMap<Permission,PermissionAddModel>();
            CreateMap<PermissionAddModel,Permission>();

            CreateMap<Permission,PermissionListDto>();
            CreateMap<PermissionListDto,Permission>();

        
        }
    }
}