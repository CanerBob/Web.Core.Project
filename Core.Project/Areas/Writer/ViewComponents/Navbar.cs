using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;

namespace Core.Project.Areas.Writer.ViewComponents;
public class Navbar:ViewComponent
{
	private readonly UserManager<Person> _userManager;

	public Navbar(UserManager<Person> userManager)
	{
		_userManager = userManager;
	}

	public async Task<IViewComponentResult> InvokeAsync() 
	{
		var item = await _userManager.FindByNameAsync(User.Identity.Name);
		ViewBag.v = item.ImageURl;
		return View(item);
	}
}
