using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AnnualPermissionApp.DTO;
using AnnualPermissionApp.UI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace AnnualPermissionApp.UI.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IPermissionService _permissionService;
        private readonly IGenericService<Permission> _genericService;
        private readonly IMapper _mapper;
        private readonly IEmployeeService _employeeService;
        public PermissionController(IGenericService<Permission> genericService, IMapper mapper, IPermissionService permissionService,IEmployeeService employeeService)
        {
            _genericService = genericService;
            _mapper = mapper;
            _permissionService = permissionService;
            _employeeService = employeeService;
        }

        public IActionResult AddPermission(int id)
        {
            TempData["id"] = id;
            return View(new PermissionAddModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(PermissionAddModel model)
        {
            //izin durumunu kontrol et
            // var permission =await _employeeService.PermissionRightThisYear(model.EmployeeId);
            // if(permission == 0){
            //     ModelState.AddModelError("","İzin vermeye çalıştığınız kullanıcının izni bulunmamaktadır");
            // }
            
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
                model.EmployeeId = (int)TempData["id"];
                //modelden gelen alanları

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