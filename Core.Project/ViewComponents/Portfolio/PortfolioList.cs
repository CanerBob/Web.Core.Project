using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Portfolio;
public class PortfolioList:ViewComponent
{
    PortfolioManager portfolioManager = new PortfolioManager(new EfCorePortfolioRepository());
    public IViewComponentResult Invoke() 
    {
        var values = portfolioManager.GetList();
        return View(values);
    }
}