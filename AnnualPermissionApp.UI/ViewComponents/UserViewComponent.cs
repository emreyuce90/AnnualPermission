using System.Collections.Generic;
using AnnualPermissionApp.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI.ViewComponents
{
    public class UserViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<AppUser> _genericService;
        public UserViewComponent(IGenericService<AppUser> genericService,IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id){
            var emp = _genericService.GetByIdAsync(id).Result;
            return View(_mapper.Map<EmployeeListDto>(emp));
        }
    }
}