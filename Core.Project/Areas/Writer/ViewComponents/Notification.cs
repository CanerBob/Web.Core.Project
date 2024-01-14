using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Areas.Writer.ViewComponents;
public class Notification:ViewComponent
{
    AnnouncementManager announcementManager = new AnnouncementManager(new EfCoreAnnouncementRepository());
    public IViewComponentResult Invoke() 
    {
        var values = announcementManager.GetList().Take(3).ToList();
        return View(values);
    }
}