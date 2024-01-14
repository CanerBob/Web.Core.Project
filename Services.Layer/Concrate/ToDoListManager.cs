using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class ToDoListManager : IToDoListService
{
	private IToDoList _toDoList;

	public ToDoListManager(IToDoList toDoList)
	{
		_toDoList = toDoList;
	}


	public ToDoList GetById(int id)
	{
		return _toDoList.GetById(id);
	}

	public List<ToDoList> GetList()
	{
		return _toDoList.GetList();
	}

	public List<ToDoList> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<ToDoList> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(ToDoList entity)
	{
		_toDoList.Add(entity);
	}

	public void TRemove(ToDoList entity)
	{
		_toDoList.Remove(entity);
	}

	public void TUpdate(ToDoList entity)
	{
		_toDoList.Update(entity);	
	}
}