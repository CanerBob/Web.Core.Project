using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Skill;
public class SkillList:ViewComponent
{
    SkillManager skillManager = new SkillManager(new EfCoreSkillRepository());
    public IViewComponentResult Invoke() 
    {
        var values = skillManager.GetList();
        return View(values);
    }
}