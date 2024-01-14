using Microsoft.AspNetCore.Mvc;
using Models.Layer.ContextDatabase;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.DashBoard;
public class FeatureStatisticks:ViewComponent
{
    AppDbContext app= new AppDbContext();
    public IViewComponentResult Invoke() 
    {
        ViewBag.v1 = app.Skills.Count();
        ViewBag.v2=app.Messages.Where(x=>x.Status==false).Count();
        ViewBag.v3=app.Messages.Where(x=>x.Status==true).Count();
        ViewBag.v4 = app.Experiences.Count();
        return View();
    }
}
