using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class AnnouncementManager : IAnnouncementService
{
    IAnnouncement _announcement;

    public AnnouncementManager(IAnnouncement announcement)
    {
        _announcement = announcement;
    }
    public Announcement GetById(int id)
    {
        return _announcement.GetById(id);
    }

    public List<Announcement> GetList()
    {
        return _announcement.GetList();
    }

	public List<Announcement> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Announcement> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Announcement entity)
    {
        _announcement.Add(entity);
    }

    public void TRemove(Announcement entity)
    {
        _announcement.Remove(entity);
    }

    public void TUpdate(Announcement entity)
    {
        _announcement.Update(entity);
    }
}