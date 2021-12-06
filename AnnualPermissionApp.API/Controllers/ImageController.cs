using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {

        private readonly IGenericService<Permission> _genericService;
        public ImageController(IGenericService<Permission> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetImagesByPermissionId(int id)
        {
            var permission = await _genericService.GetByIdAsync(id);
            if(!String.IsNullOrWhiteSpace(permission.RequestPicturePath)){
                return File($"/img/{permission.RequestPicturePath}","image/jpeg");
            }
            return NotFound("Aradığınız resim veritabanımızda kayıtlı değil");
        }
    }
}