using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfCoreSkillRepository());
        public IActionResult Index()
        {
            var values= skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {
            return View();    
        }
        [HttpPost]
        public IActionResult AddSkill(Skill model)
        {
            skillManager.TAdd(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var skill = skillManager.GetById(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill model)
        {
            skillManager.TUpdate(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult DeleteSkill(int id) 
        {
           var skill= skillManager.GetById(id);
            skillManager.TRemove(skill);
            return RedirectToAction(nameof(Index));
        }
    }
}