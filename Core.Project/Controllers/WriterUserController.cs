using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Newtonsoft.Json;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;

namespace Core.Project.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUSerManager writerUSerManager = new WriterUSerManager(new EfCoreWriterUserRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserList() 
        {
            var values = JsonConvert.SerializeObject(writerUSerManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddPerson(Person model) 
        {
            writerUSerManager.TAdd(model);
            var values = JsonConvert.SerializeObject(model);
            return Json(values);
        }
    }
}
