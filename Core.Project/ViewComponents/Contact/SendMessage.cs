using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Contact;
public class SendMessage:ViewComponent
{
	MessageManager messageManager=new MessageManager(new EfCoreMessageRepository());
	[HttpGet]
	public IViewComponentResult Invoke() 
	{
		return View();
	}
	//[HttpPost]
	//public IViewComponentResult Invoke(Message model) 
	//{
	//	model.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
	//	model.Status = true;
	//	messageManager.TAdd(model);
	//	return View();
	//}
}