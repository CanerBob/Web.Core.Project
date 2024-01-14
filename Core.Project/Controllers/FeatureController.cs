using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfCoreFeatureRepository());
        [HttpGet]
        public IActionResult Index()
        {
           
            var values = featureManager.GetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature model)
        {
            featureManager.TUpdate(model);
            return RedirectToAction("Index", "Default");
        }
    }
}
