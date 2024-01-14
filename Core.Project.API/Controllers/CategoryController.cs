using Core.Project.API.Dal.ApiContext;
using Core.Project.API.Dal.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		AppDbcontext app = new AppDbcontext();
		[HttpGet]
		public IActionResult CategoryList()
		{
			return Ok(app.Categories.ToList());
		}
		[HttpGet("{id}")]
		public IActionResult FindCategoryId(int id)
		{
			var item = app.Categories.Find(id);
			if (item != null)
			{
				return Ok(item);
			}
			else
			{
				return NotFound();
			}
		}
		[HttpPost]
		public IActionResult AddCategory(Category model)
		{
			app.Add(model);
			app.SaveChanges();
			return Created("", model);
		}
		[HttpDelete]
		public IActionResult DeleteCategory(int id)
		{
			var item = app.Categories.Find(id);
			if (item == null)
			{
				return NotFound();
			}
			else
			{
				app.Remove(item);
				app.SaveChanges();
				return NoContent();
			}
		}
		[HttpPut]
		public IActionResult UpdateCategory(Category model) 
		{
			var item = app.Find<Category>(model.CategoryId);
			if (item == null) 
			{
				return NotFound();
			}
            else
            {
                item.CategoryName= model.CategoryName;
				app.Update(item);
				app.SaveChanges();
				return Ok(item);
            }
        }
	}
}