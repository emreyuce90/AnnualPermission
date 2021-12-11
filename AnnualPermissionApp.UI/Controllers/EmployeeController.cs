using System.Collections.Generic;
using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;


namespace PermissionApp.AnnualPermissionApp.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private IMapper _mapper;
        private readonly IGenericService<Employee> _employeeService;
        public EmployeeController(IGenericService<Employee> employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<EmployeeListDto>>(await _employeeService.GetAllAsync()));
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new EmployeeAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeAddDto model)
        {
            if(ModelState.IsValid){
                //DO İT
               await _employeeService.AddAsync(_mapper.Map<Employee>(model));
               return RedirectToAction("Index");
            }
            
            return View(model);
        }
    }
}