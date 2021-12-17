using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;


namespace PermissionApp.AnnualPermissionApp.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IGenericService<Employee> _employeeService;
        public EmployeeController(IGenericService<Employee> employeeService, IMapper mapper, IConfiguration configuration)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            //dbden gelen data
            var employeeList = await _employeeService.GetAllAsync();
            //dto katmanımız
            List<EmployeeListDto> emp = new List<EmployeeListDto>();
            //iterating db list
            foreach (var employee in employeeList)
            {
                EmployeeListDto e = new EmployeeListDto();
                e.Id = employee.Id;
                e.Name = employee.Name;
                e.Surname = employee.Surname;
                e.Title = employee.Title;
                e.EnterDate = employee.EnterDate;
                //! Mantığı kontrol et
                if (DateTime.Now.Year - employee.EnterDate.Year <= 1)
                {
                    e.LegalPermission = 0;
                }
                else if (DateTime.Now.Year - employee.EnterDate.Year <= 5)
                {
                    e.LegalPermission = 14;
                }
                else if (DateTime.Now.Year - employee.EnterDate.Year > 5 && DateTime.Now.Year - employee.EnterDate.Year < 15 )
                {
                    e.LegalPermission = 20;
                }
                else
                {
                    e.LegalPermission = 26;
                }
                emp.Add(e);
            }
            return View(emp);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new EmployeeAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeAddDto model)
        {
            if (ModelState.IsValid)
            {
                //DO İT
                await _employeeService.AddAsync(_mapper.Map<Employee>(model));
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var emp = await _employeeService.GetByIdAsync(id);
            if (emp != null)
            {
                return View(_mapper.Map<EmployeeUpdateDto>(emp));
            }
            //Loglama yapılacak
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.UpdateAsync(_mapper.Map<Employee>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {


            if (id != 0)
            {
                await _employeeService.DeleteAsync(new Employee { Id = id });
                return Json(null);
            }
            return BadRequest("Silmek istediğiniz plasiyer veritabanımızda kayıtl değil");
        }
    }
}