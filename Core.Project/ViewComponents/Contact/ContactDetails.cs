using Microsoft.AspNetCore.Mvc;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.ViewComponents.Contact
{
	public class ContactDetails:ViewComponent
	{
		ContactManager contactManager = new ContactManager(new EfCoreContactRepository());
		public IViewComponentResult Invoke() 
		{
			var values=	contactManager.GetList();
			return View(values);
		}
	}
}
