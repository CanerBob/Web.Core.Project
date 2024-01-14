using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.DashBoard;
public class ProjectList:ViewComponent
{
    PortfolioManager pManager = new PortfolioManager(new EfCorePortfolioRepository());
    public IViewComponentResult Invoke() 
    {
       var values= pManager.GetList();
        return View(values);
    }
}
