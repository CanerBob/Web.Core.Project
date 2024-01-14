using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Models.Layer.ContextDatabase;

namespace Core.Project.Areas.Writer.Controllers;
[Area("Writer")]
public class DashBoardController : Controller
{
    private readonly UserManager<Person> _userManager;

    public DashBoardController(UserManager<Person> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        ViewBag.v1=values.FirstName+ " " +values.LastName;
        AppDbContext app = new AppDbContext();
        ViewBag.v2 = app.WriterMessages.Where(x => x.Receiver == values.Email).Count();
        ViewBag.v3 = app.Announcements.Count();
        ViewBag.v4 = app.Users.Count();
        ViewBag.v5 = app.WriterMessages.Where(x => x.Sender == values.Email).Count();
        return View();
    }
}