using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Layer.AllModels;
using Models.Layer.ContextDatabase;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Areas.Writer.Controllers;
[Area("Writer")]
[Route("Writer/Message")]
public class MessageController : Controller
{
    WriterMessageManager writerMessage = new WriterMessageManager(new EfCoreWriterMessageRepository());
    private readonly UserManager<Person> _userManager;

	public MessageController(UserManager<Person> userManager)
	{
		_userManager = userManager;
	}
	[Route("")]
	[Route("RecieverMessage")]
	public async Task<IActionResult> RecieverMessage(string p)
	{
		var values = await _userManager.FindByNameAsync(User.Identity.Name);
		p = values.Email;
		var messageList = writerMessage.GetListRecieverMessage(p);
		return View(messageList);
	}
    [Route("")]
    [Route("SenderMessage")]
    public async Task<IActionResult> SenderMessage(string p)
	{
		var values = await _userManager.FindByNameAsync(User.Identity.Name);
		p = values.Email;
		var messagelist = writerMessage.GetListSendMessage(p);
		return View(messagelist);
	}
	[HttpGet]
	[Route("SenderMessageDetails/{id}")]
	public IActionResult SenderMessageDetails(int id)
	{
		WriterMessage message = writerMessage.GetById(id);
		return View(message);
	}
	[HttpGet]
    [Route("RecieverMessageDetails/{id}")]
    public IActionResult RecieverMessageDetails(int id)
	{
		WriterMessage messsage = writerMessage.GetById(id);
		return View(messsage);
	}
	[HttpGet]
    [Route("")]
    [Route("SendMessage")]
    public IActionResult SendMessage()
	{
		return View();
	}
	[HttpPost]
    [Route("")]
    [Route("SendMessage")]
    public async Task<IActionResult> SendMessage(WriterMessage model) 
	{
		var values = await _userManager.FindByNameAsync(User.Identity.Name);
		string mail=values.Email;
		string name = values.FirstName + " " + values.LastName;
		model.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
		model.Sender = mail;
		model.SenderName= name;
		AppDbContext app= new AppDbContext();
		var person = app.Users.Where(x => x.Email == model.Receiver)
			.Select(y=>y.FirstName + " " + y.LastName).FirstOrDefault();
		model.ReceiverName = person;
		writerMessage.TAdd(model);
		return RedirectToAction(nameof(SenderMessage));
	}
}