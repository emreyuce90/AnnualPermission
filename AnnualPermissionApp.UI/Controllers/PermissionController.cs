using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using AnnualPermissionApp.UI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PermissionController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IPermissionService _permissionService;
        private readonly IGenericService<Permission> _genericService;
        private readonly IMapper _mapper;
        private readonly IAppUserService _employeeService;
        public PermissionController(IGenericService<Permission> genericService, IMapper mapper, IPermissionService permissionService, IAppUserService employeeService, UserManager<AppUser> userManager)
        {
            _genericService = genericService;
            _mapper = mapper;
            _permissionService = permissionService;
            _employeeService = employeeService;
            _userManager = userManager;
        }

        public IActionResult AddPermission(int id)
        {
            TempData["id"] = id;
            return View(new PermissionAddModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(PermissionAddModel model)
        {
           
            model.AppUserId = (int)TempData["id"];
                //modelden gelen alanları

            if (ModelState.IsValid)
            {

                if (model.Image != null)
                {
                    if (model.Image.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("", "Tanınmayan dosya uzantısı,lütfen sadece image/jpeg dosyalarını ekleyin");
                    }
                    //mmvlşskmlmsğflsğidöşisd646464.png
                    var name = Guid.NewGuid() + model.Image.FileName;
                    //c:documetns...wwwwroot/img/mmvlşskmlmsğflsğidöşisd646464.png
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/", name);
                    //sana verdiğim pathi create et
                    var stream = new FileStream(path, FileMode.Create);
                    await model.Image.CopyToAsync(stream);
                    model.RequestPicturePath = name;
                }
                
                

                await _genericService.AddAsync(_mapper.Map<Permission>(model));

                return RedirectToAction("Index", "Employee");
            }
            return View(model);
        }

        
        [HttpGet]
        public async Task<IActionResult> GetPermissionList(int id)
        {
            ViewBag.Id = id;
            return View(_mapper.Map<List<PermissionListDto>>(await _permissionService.GetPermissionsByEmployeeIdAsync(id)));
        }
    }
}