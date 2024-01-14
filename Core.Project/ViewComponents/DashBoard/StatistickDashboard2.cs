using Microsoft.AspNetCore.Mvc;
using Models.Layer.ContextDatabase;

namespace Core.Project.ViewComponents.DashBoard;
public class StatistickDashboard2:ViewComponent
{
    AppDbContext app = new AppDbContext();
    public IViewComponentResult Invoke() 
    {
        ViewBag.d1 = app.Portfolios.Count();
        ViewBag.d2 = app.Messages.Count();
        ViewBag.d3 = app.Skills.Count();
        return View();
    }
}
