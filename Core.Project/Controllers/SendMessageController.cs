using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Abstract;
using Services.Layer.Concrate;

namespace Core.Project.Controllers;
public class SendMessageController : Controller
{
	MessageManager _messageManager = new MessageManager(new EfCoreMessageRepository());
	public IActionResult Index()
	{
		return View();
	}
	[HttpPost]
	public IActionResult Index(Message message) 
	{
		message.Date = DateTime.Now.ToLocalTime();
		message.Status = true;
		_messageManager.TAdd(message);
		return Redirect("/Default/Index#contact");
	}
}
