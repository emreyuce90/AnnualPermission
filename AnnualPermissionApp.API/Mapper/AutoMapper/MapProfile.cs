using AutoMapper;
using PermissionApp.AnnualPermissionApp.API.Models;
using PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos;
using PermissionApp.AnnualPermissionApp.DTO.PermissionDtos;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.API.Mapper.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Employee
            CreateMap<Employee, EmployeeListDto>();
            CreateMap<EmployeeListDto, Employee>();

            CreateMap<Employee, EmployeeAddDto>();
            CreateMap<EmployeeAddDto, Employee>();

            CreateMap<Employee, EmployeeUpdateDto>();
            CreateMap<EmployeeUpdateDto, Employee>();

            //Permission

            CreateMap<Permission, PermissionListDto>();
            CreateMap<PermissionListDto, Permission>();

            CreateMap<Permission,PermissionAddModel>();
            CreateMap<PermissionAddModel,Permission>();

            CreateMap<Permission,PermissionUpdateModel>();
            CreateMap<PermissionUpdateModel,Permission>();

        }
    }
}