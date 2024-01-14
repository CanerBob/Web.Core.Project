using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult HeaderPartial() 
		{
			return PartialView();
		}
		public PartialViewResult NavbarPartial() 
		{
			return PartialView();
		}
		[HttpGet]
		public PartialViewResult SendMessage() 
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SendMessage(Message model) 
		{
			MessageManager messageManager = new MessageManager(new EfCoreMessageRepository());
			model.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			model.Status = true;
			messageManager.TAdd(model);
			return PartialView();
		}
	}
}
