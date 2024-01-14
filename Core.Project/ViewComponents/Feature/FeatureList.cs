using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Feature;
public class FeatureList:ViewComponent
{
    FeatureManager featureManager = new FeatureManager(new EfCoreFeatureRepository());
    public IViewComponentResult Invoke() 
    {
        var values = featureManager.GetList();
        return View(values);
    }
}
