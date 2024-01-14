using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class WriterUSerManager : IWriterUserService
{
    IWriterUser _writerUser;

    public WriterUSerManager(IWriterUser writerUser)
    {
        _writerUser = writerUser;
    }

    public Person GetById(int id)
    {
        return _writerUser.GetById(id);
    }

    public List<Person> GetList()
    {
        return _writerUser.GetList();
    }

    public List<Person> GetListByFilter(string p)
    {
        throw new NotImplementedException();
    }

    public void TAdd(Person entity)
    {
        _writerUser.Add(entity);
    }

    public void TRemove(Person entity)
    {
        _writerUser.Remove(entity);
    }

    public void TUpdate(Person entity)
    {
        _writerUser.Update(entity);
    }
}