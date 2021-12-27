using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
    public class ErrorController:Controller
    {
        [Route("/Error")]
        [HttpGet]
        public IActionResult GlobalErrorHandler()
        {
            var errorHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ErrorPath = errorHandler.Path;
            ViewBag.Message = errorHandler.Error.Message;
            ViewBag.StackTrace = errorHandler.Error.StackTrace;
            return View("Error");
        }
    }
}