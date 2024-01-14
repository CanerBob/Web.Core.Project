using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
	public class DefaultController : Controller
	{
		AnnouncementManager _announcement = new AnnouncementManager(new EfCoreAnnouncementRepository());
		public IActionResult Index()
		{
			var values = _announcement.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult Details(int id) 
		{
			Announcement announcement = _announcement.GetById(id);
			return View(announcement);
		}
	}
}
