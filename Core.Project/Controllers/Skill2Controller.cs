using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Newtonsoft.Json;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
	public class Skill2Controller : Controller
	{
		SkillManager skillManager = new SkillManager(new EfCoreSkillRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ListSkill() 
		{
			var values = JsonConvert.SerializeObject(skillManager.GetList());
			return Json(values);
		}
		[HttpPost]
		public IActionResult AddSkill(Skill model) 
		{
			skillManager.TAdd(model);
			var values = JsonConvert.SerializeObject(model);
			return Json(values);
		}
	}
}
