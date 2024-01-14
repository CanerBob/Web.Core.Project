using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class SserviceManager : IServiceservice
{
	private IService _service;

	public SserviceManager(IService service)
	{
		_service = service;
	}

	public Sservice GetById(int id)
	{
		return _service.GetById(id);
	}

	public List<Sservice> GetList()
	{
		return _service.GetList();
	}

	public List<Sservice> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Sservice> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Sservice entity)
	{
		_service.Add(entity);
	}

	public void TRemove(Sservice entity)
	{
		_service.Remove(entity);
	}

	public void TUpdate(Sservice entity)
	{
		_service.Update(entity);
	}
}