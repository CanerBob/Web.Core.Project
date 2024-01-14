using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Service;
public class ServiceList:ViewComponent
{
    SserviceManager serviceManager = new SserviceManager(new EfCoreServiceRepository());
    public IViewComponentResult Invoke() 
    {
        var values = serviceManager.GetList();
        return View(values);
    }
}