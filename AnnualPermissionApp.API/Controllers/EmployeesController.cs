using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DTO.EmployeesDtos;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IGenericService<Employee> _genericService;
        private readonly IMapper _mapper;
        public EmployeesController(IGenericService<Employee> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_mapper.Map<List<EmployeeListDto>>(await _genericService.GetAllAsync()));
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeAddDto e)
        {
            if (ModelState.IsValid)
            {
                // dto olarak gelen modeli orijinaline maple 
                await _genericService.AddAsync(_mapper.Map<Employee>(e));
                return Created("", e);
            }
            return BadRequest("Lütfen bilgileri doğru girdiğinizden emin olun");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployees(int id, [FromForm] EmployeeUpdateDto e)
        {
            //tarayıcıdan girilen id 2 eşit olmalı formdan gönderilen id ye
            if (id != e.Id)
            {
                return BadRequest("Girdiğiniz idye ait kullanıcı veritabanında mevcut değil");
            }
            //güncellenecek kayıt
            var emp = await _genericService.GetByIdAsync(e.Id);
            emp.Name = e.Name;
            emp.Surname = e.Surname;
            emp.EnterDate = e.EnterDate;
            emp.Title = e.Title;

            await _genericService.UpdateAsync(_mapper.Map<Employee>(emp));
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var emp = await _genericService.GetByIdAsync(id);
            return Ok(_mapper.Map<Employee>(emp));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genericService.DeleteAsync(new Employee { Id = id });
            return NoContent();
        }
    }
}