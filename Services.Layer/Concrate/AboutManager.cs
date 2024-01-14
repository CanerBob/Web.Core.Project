using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class AboutManager : IAboutService
{
	private IAbout _about;

	public AboutManager(IAbout about)
	{
		_about = about;
	}
	public About GetById(int id)
	{
		return _about.GetById(id);
	}

	public List<About> GetList()
	{
		return _about.GetList();
	}

	public List<About> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<About> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(About entity)
	{
		_about.Add(entity);
	}

	public void TRemove(About entity)
	{
		_about.Remove(entity);
	}

	public void TUpdate(About entity)
	{
		_about.Update(entity);
	}
}