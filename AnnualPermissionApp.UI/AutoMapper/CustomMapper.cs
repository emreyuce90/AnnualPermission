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
            CreateMap<AppUser,EmployeeListDto>();
            CreateMap<EmployeeListDto,AppUser>();
            
            CreateMap<AppUser,EmployeeAddDto>();
            CreateMap<EmployeeAddDto,AppUser>();

            CreateMap<EmployeeUpdateDto,AppUser>();
            CreateMap<AppUser,EmployeeUpdateDto>();

            CreateMap<Permission,PermissionAddModel>();
            CreateMap<PermissionAddModel,Permission>();

            CreateMap<Permission,PermissionListDto>();
            CreateMap<PermissionListDto,Permission>();

        
        }
    }
}