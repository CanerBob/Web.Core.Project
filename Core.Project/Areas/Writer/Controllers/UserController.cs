using Core.Project.Areas.Writer.Models;
using Core.Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;

namespace Core.Project.Areas.Writer.Controllers
{
    //Caner123**
    [Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class UserController : Controller
	{
		private readonly UserManager<Person> _userManager;
        private readonly SignInManager<Person> _signinManager;

        public UserController(UserManager<Person> userManager, SignInManager<Person> signinManager)
        {
            _userManager = userManager;
            _signinManager = signinManager;
        }

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Register(PersonRegisterViewModel model) 
		{
            if (ModelState.IsValid)
            {
                Person p = new Person()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
					ImageURl=model.ImageUrl,
                    Email = model.Email,
                };
                if (model.ConfirmPassword == model.Password) 
                {
					var result = await _userManager.CreateAsync(p, model.Password);
					if (result.Succeeded)
					{
						return RedirectToAction(nameof(Login));
					}
					else
					{

						foreach (var item in result.Errors)
						{
							ModelState.AddModelError("", item.Description);
						}
					}
				}
            }
            return View(model);
        }
        [HttpGet]
		public IActionResult Login() 
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model) 
		{
            if (ModelState.IsValid)
            {
                var result = await _signinManager.PasswordSignInAsync(model.UserName, model.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre");
                }
            }
            return View();
		}
        public async Task<IActionResult> Logout() 
        {
         await _signinManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
	}
}