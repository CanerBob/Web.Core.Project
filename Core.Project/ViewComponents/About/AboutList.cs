using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.About;
public class AboutList:ViewComponent
{
    AboutManager aboutManager = new AboutManager(new EfCoreAboutRepository());
    public IViewComponentResult Invoke() 
    {
        var values = aboutManager.GetList();
        return View(values);
    }
}
