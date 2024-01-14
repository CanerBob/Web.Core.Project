using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers;

public class ContactController : Controller
{
    MessageManager messageManager = new MessageManager(new EfCoreMessageRepository());
    public IActionResult Index()
    {
        var values = messageManager.GetList();
        return View(values);
    }
    public IActionResult DeleteContact(int id)
    {
        var values = messageManager.GetById(id);
        messageManager.TRemove(values);
        return RedirectToAction(nameof(Index));
    }
    public IActionResult ViewContact(int id)
    {
        var values= messageManager.GetById(id);
        return View(values);
    }
}