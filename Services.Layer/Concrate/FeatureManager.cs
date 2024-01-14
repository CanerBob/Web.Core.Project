using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class FeatureManager : IFeatureService
{
	private IFeature _feature;

	public FeatureManager(IFeature feature)
	{
		_feature = feature;
	}

	public Feature GetById(int id)
	{
		return _feature.GetById(id);
	}

	public List<Feature> GetList()
	{
		return _feature.GetList();
	}

	public List<Feature> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Feature> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Feature entity)
	{
		_feature.Add(entity);
	}

	public void TRemove(Feature entity)
	{
		_feature.Remove(entity);
	}

	public void TUpdate(Feature entity)
	{
		_feature.Update(entity);
	}
}