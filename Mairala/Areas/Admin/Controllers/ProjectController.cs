using Microsoft.AspNetCore.Mvc;

namespace Mairala.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
