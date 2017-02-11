using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AntiforgeryTokenAjaxPost.Controllers
{
    public class TestController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public JsonResult Index(string value)
        {
            return Json(new {status =true});
        }
    }
}
