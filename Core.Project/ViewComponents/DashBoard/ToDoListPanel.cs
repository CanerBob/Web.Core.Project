using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.DashBoard;
public class ToDoListPanel:ViewComponent
{
    ToDoListManager manager = new ToDoListManager(new EfCoreToDoListRepository());
    public IViewComponentResult Invoke() 
    {
        var values= manager.GetList();
        return View(values);
    }
}
