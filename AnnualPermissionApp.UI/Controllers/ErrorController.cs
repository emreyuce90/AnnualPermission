using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AnnualPermissionApp.UI.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public IActionResult GlobalErrorHandler()
        {
            var errorHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ErrorPath = errorHandler.Path;
            ViewBag.Message = errorHandler.Error.Message;
            ViewBag.StackTrace = errorHandler.Error.StackTrace;
            return View("ErrorPage");
        }

        // [Route("/Errorstatus")]
        // public IActionResult StatusPageErrorHandler()
        // {
        //     var statusCode = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
        //     ViewBag.ErrorPath = statusCode.OriginalPath;
        //     ViewBag.ErrorPath = statusCode.OriginalQueryString;
        //     return View("StatusError");
        // }
    }
}