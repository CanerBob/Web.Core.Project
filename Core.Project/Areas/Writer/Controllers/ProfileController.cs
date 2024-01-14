using Core.Project.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;

namespace Core.Project.Areas.Writer.Controllers;

[Area("Writer")]
[Route("Writer/[controller]/[action]")]
public class ProfileController : Controller
{
	private readonly UserManager<Person> _userManager;

    public ProfileController(UserManager<Person> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
	{
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditViewModel model = new UserEditViewModel();
        model.FirstName = values.FirstName;
        model.LastName = values.LastName;
        //model.PictureUrl = values.ImageURl;
		return View(model);
	}
    [HttpPost]
    public async Task<IActionResult> Index(UserEditViewModel model) 
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        if (model.Picture!=null)
        {
            var resoure = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Picture.FileName);
            var imagename = Guid.NewGuid() + extension;
            var savelocation = resoure + "/wwwroot/UserImage/" + imagename;
            var stream = new FileStream(savelocation, FileMode.Create);
            await model.Picture.CopyToAsync(stream);
            user.ImageURl = imagename;
        }
        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
        var result= await _userManager.UpdateAsync(user);
        if (result.Succeeded) 
        {
            return RedirectToAction("Login", "User");
        }
        return View();
    }
}
//Yeni Şifre Caner123**/