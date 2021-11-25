using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.API.Models;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DTO.PermissionDtos;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Permission> _genericService;
        public PermissionsController(IGenericService<Permission> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<PermissionListDto>>(await _genericService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<PermissionListDto>(await _genericService.GetByIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PermissionAddModel p)
        {
            if (ModelState.IsValid)
            {
                //Gelen datada fotoğraf var ise
                if (p.RequestPicture != null)
                {

                    if (p.RequestPicture.ContentType != "image/jpeg")
                    {
                        return BadRequest("Lütfen sadece jpg/image uzantılı görseller yükleyiniz");
                    }
                    var name = Guid.NewGuid() + p.RequestPicture.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", name);
                    var stream = new FileStream(path, FileMode.Create);
                    await p.RequestPicture.CopyToAsync(stream);
                    p.RequestPicturePath = name;
                }

                await _genericService.AddAsync(_mapper.Map<Permission>(p));
                return Created("", p);
            }
            return BadRequest("Girdiğiniz bilgilerde hata var lütfen düzgün giriniz");
        }

        //UPDATE
        /*
                public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestPicturePath { get; set; }
        public int DaysCount { get; set; }
        public string Description { get; set; }
*/
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] PermissionUpdateModel p)
        {
            if (id != p.Id)
            {
                return BadRequest("Veritabanında böyle bir kayıt bulunamadı");
            }
            var updatedData = await _genericService.GetByIdAsync(p.Id);
            if (p.RequestPicture != null)
            {
                if (p.RequestPicture.ContentType != "image/jpeg")
                {
                    return BadRequest("Lütfen sadece jpg/image uzantılı görseller yükleyiniz");
                }
                var name = Guid.NewGuid() + p.RequestPicture.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", name);
                var stream = new FileStream(path, FileMode.Create);
                await p.RequestPicture.CopyToAsync(stream);
                updatedData.RequestPicturePath = name;
            }

            updatedData.EmployeeId = p.EmployeeId;
            updatedData.StartDate = p.StartDate;
            updatedData.EndDate = p.EndDate;
            updatedData.DaysCount = p.DaysCount;
            updatedData.Description = p.Description;
            await _genericService.UpdateAsync(updatedData);
            return NoContent();
        }
        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genericService.DeleteAsync(new Permission { Id = id });
            return NoContent();
        }


    }
}