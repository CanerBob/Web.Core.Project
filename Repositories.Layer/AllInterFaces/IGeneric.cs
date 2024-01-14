using System.Linq.Expressions;

namespace Repositories.Layer.AllInterFaces;
public interface IGeneric<T> where T : class
{
	void Add(T entity);
	void Remove(T entity);
	void Update(T entity);
	List<T> GetList();
	T GetById(int id);
	List<T> GetByFilters(Expression<Func<T,bool>> filter);
}