using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Models.Layer.ContextDatabase;
using Repositories.Layer.AllInterFaces;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
	public class MessageController : Controller
	{
		WriterMessageManager _writerMessage = new WriterMessageManager(new EfCoreWriterMessageRepository());
		private readonly UserManager<Person > _userManager;

		public MessageController(UserManager<Person> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> RecieverMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = _writerMessage.GetListRecieverMessage(p);
			return View(messageList);
		}
		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messagelist = _writerMessage.GetListSendMessage(p);
			return View(messagelist);
		}
		public IActionResult SenderMessageDetails(int id)
		{
			WriterMessage message = _writerMessage.GetById(id);
			return View(message);
		}
		public IActionResult RecieverMessageDetails(int id)
		{
			WriterMessage messsage = _writerMessage.GetById(id);
			return View(messsage);
		}
		[HttpGet]
		public IActionResult SendMessage() 
		{
			return View();	
		}
		[HttpPost]
		public async Task<IActionResult> SendMessage(WriterMessage model) 
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			string mail = values.Email;
			string name = values.FirstName + " " + values.LastName;
			model.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			model.Sender = mail;
			model.SenderName = name;
			AppDbContext app = new AppDbContext();
			var person = app.Users.Where(x => x.Email == model.Receiver)
				.Select(y => y.FirstName + " " + y.LastName).FirstOrDefault();
			model.ReceiverName = person;
			_writerMessage.TAdd(model);
			return RedirectToAction(nameof(SenderMessage));
		}
	}
}
