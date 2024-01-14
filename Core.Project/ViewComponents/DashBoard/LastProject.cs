using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.DashBoard;
public class LastProject:ViewComponent
{
    public IViewComponentResult Invoke() 
    {
        return View();
    }
}
