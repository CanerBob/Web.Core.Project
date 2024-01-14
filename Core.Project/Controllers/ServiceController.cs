using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
	public class ServiceController : Controller
	{
		SserviceManager serviceManager = new SserviceManager(new EfCoreServiceRepository());
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.v1 = "Hizmet Listesi";
			ViewBag.v2 = "Hizmetlerim";
			ViewBag.v3 = "Hizmet Listesi";
			var values = serviceManager.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddService() 
		{
			ViewBag.v1 = "Hizmet Ekleme";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v2 = "Hizmet Ekleme Sayfası";
			return View();	
		}
        [HttpPost]
        public IActionResult AddService(Sservice model)
        {
			serviceManager.TAdd(model);
            return RedirectToAction(nameof(Index));
        }
		[HttpGet]
		public IActionResult DeleteService(int id) 
		{
			var item=serviceManager.GetById(id);
			serviceManager.TRemove(item);
			return RedirectToAction(nameof(Index));
		}
		[HttpGet]
		public IActionResult EditService(int id) 
		{
			ViewBag.v1 = "Hizmetler";
			ViewBag.v2 = "Hizmet";
			ViewBag.v3 = "Hizmet Güncelleme Sayfası";
			var item=serviceManager.GetById(id);
			return View(item);
		}
        [HttpPost]
        public IActionResult EditService(Sservice model)
        {
            serviceManager.TUpdate(model);
            return RedirectToAction(nameof(Index));
        }
    }
}