using System.Linq.Expressions;

namespace Repositories.Layer.GenericRepo;
public class GenericRepository<T> : IGeneric<T> where T : class
{
	public void Add(T entity)
	{
		using var app = new AppDbContext();
		app.Add(entity);
		app.SaveChanges();
	}

	public List<T> GetByFilters(Expression<Func<T, bool>> filter)
	{
		using var app= new AppDbContext();
		return app.Set<T>().Where(filter).ToList(); 
	}

	public T GetById(int id)
	{
		using var app= new AppDbContext();
		return app.Set<T>().Find(id);
	}

	public List<T> GetList()
	{
		using var app= new AppDbContext();
		return app.Set<T>().ToList();
	}

	public void Remove(T entity)
	{
		using var app = new AppDbContext();
		app.Remove(entity);
		app.SaveChanges();
	}

	public void Update(T entity)
	{
		using var app = new AppDbContext();
		app.Update(entity);
		app.SaveChanges();
	}
}