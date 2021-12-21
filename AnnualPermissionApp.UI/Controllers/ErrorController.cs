using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers{
    public class ErrorController:Controller{
        [Route("/Error")]
        public IActionResult Error()
        {
             var error= HttpContext.Features.Get<IExceptionHandlerPathFeature>();
             //Loglama yap
             //Client a bir response dön
             
            return View();
        }
    }
}