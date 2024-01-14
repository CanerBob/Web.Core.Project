using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.DashBoard;

public class MessageList:ViewComponent
{
	UserMessageManager uMessage = new UserMessageManager(new EfCoreUserMessageRepository());
	public IViewComponentResult Invoke() 
	{
		var values=uMessage.GetUserMessageWithPerson().Take(4).ToList();
		return View(values);
	}
}
