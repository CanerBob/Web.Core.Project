using System.Linq.Expressions;

namespace Services.Layer.Abstract;
public interface IGenericService<T> where T : class
{
	void TAdd(T entity);
	void TRemove(T entity);
	void TUpdate(T entity);
	List<T> GetList();
	T GetById(int id);
	List<T> GetListByFilter(string p);
}