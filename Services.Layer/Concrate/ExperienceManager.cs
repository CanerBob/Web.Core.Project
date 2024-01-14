using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class ExperienceManager : IExperienceService
{
	private IExperience _experince;

	public ExperienceManager(IExperience experince)
	{
		_experince = experince;
	}
	public Experience GetById(int id)
	{
		return _experince.GetById(id);
	}

	public List<Experience> GetList()
	{
		return _experince.GetList();
	}

	public List<Experience> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Experience> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Experience entity)
	{
		_experince.Add(entity);
	}

	public void TRemove(Experience entity)
	{
		_experince.Remove(entity);
	}

	public void TUpdate(Experience entity)
	{
		_experince.Update(entity);
	}
}