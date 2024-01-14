using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
