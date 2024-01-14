using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfCoreAboutRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.GetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About model)
        {
            aboutManager.TUpdate(model);
            return RedirectToAction("Index", "Default");
        }
    }
}
