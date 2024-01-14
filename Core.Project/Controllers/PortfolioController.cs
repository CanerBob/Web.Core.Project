using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Models.Layer.AllModels;
using Repositories.Layer.EfCore;
using Services.Layer.Concrate;
using Services.Layer.ValidationRules;


namespace Core.Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfCorePortfolioRepository());
        public IActionResult Index()
        {
            var values = portfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio model)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                portfolioManager.TAdd(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeletePortfolio(int id) 
        {
            var values= portfolioManager.GetById(id);
            portfolioManager.TRemove(values);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id) 
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Güncelleme";
            var item=portfolioManager.GetById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio model)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(model);
            if (result.IsValid)
            {
                portfolioManager.TUpdate(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
