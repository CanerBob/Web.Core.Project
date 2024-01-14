using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class SocialMediaManager : ISocialMediaService
{
	private ISocialMedia _socialMedia;

	public SocialMediaManager(ISocialMedia socialMedia)
	{
		_socialMedia = socialMedia;
	}

	public SocialMedia GetById(int id)
	{
		return _socialMedia.GetById(id);
	}

	public List<SocialMedia> GetList()
	{
		return _socialMedia.GetList();
	}

	public List<SocialMedia> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<SocialMedia> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(SocialMedia entity)
	{
		_socialMedia.Add(entity);
	}

	public void TRemove(SocialMedia entity)
	{
		_socialMedia.Remove(entity);
	}

	public void TUpdate(SocialMedia entity)
	{
		_socialMedia.Update(entity);	
	}
}
