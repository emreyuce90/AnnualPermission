using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;


namespace PermissionApp.AnnualPermissionApp.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IGenericService<AppUser> _employeeService;
        private readonly IAppUserService _service;
        public EmployeeController(IGenericService<AppUser> employeeService, IMapper mapper, IConfiguration configuration, IAppUserService service)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _configuration = configuration;
            _service = service;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            ViewBag.SearchString = searchString;
            if (String.IsNullOrWhiteSpace(searchString))
            {
                //kullanıcı herhangi bir arama yapmadıysa
                return View(_mapper.Map<List<EmployeeListDto>>(await _employeeService.GetAllAsync()));
            }
            //filtreli sorgu

            return View(_mapper.Map<List<EmployeeListDto>>(await _service.GetEmployeeListsBySearchString(searchString)));


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
                await _employeeService.AddAsync(_mapper.Map<AppUser>(model));
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
                await _employeeService.UpdateAsync(_mapper.Map<AppUser>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {


            if (id != 0)
            {
                await _employeeService.DeleteAsync(new AppUser { Id = id });
                return Json(null);
            }
            return BadRequest("Silmek istediğiniz plasiyer veritabanımızda kayıtl değil");
        }
    }
}