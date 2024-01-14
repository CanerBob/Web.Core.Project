using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers;
public class ErrorPagesController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
	public IActionResult Error404() 
	{
		return View();
	}
}