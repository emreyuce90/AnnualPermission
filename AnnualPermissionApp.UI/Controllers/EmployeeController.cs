using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;
using PermissionApp.AnnualPermissionApp.UI.Models;

namespace PermissionApp.AnnualPermissionApp.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private IMapper _mapper;
        private readonly IGenericService<Employee> _employeeService;
        public EmployeeController(IGenericService<Employee> employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<EmployeeViewModel>>(await _employeeService.GetAllAsync()));
        }
    }
}