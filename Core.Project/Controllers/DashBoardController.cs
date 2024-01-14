using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İStatistikler";
            ViewBag.v3 = "İstatistik Sayfası";
            return View();
        }
    }
}
