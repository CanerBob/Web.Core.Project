using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class ContactManager : IContactService
{
	IContact _contact;

	public ContactManager(IContact contact)
	{
		_contact = contact;
	}
	public Contact GetById(int id)
	{
		return _contact.GetById(id);
	}

	public List<Contact> GetList()
	{
		return _contact.GetList();
	}

	public List<Contact> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Contact> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Contact entity)
	{
		_contact.Add(entity);
	}

	public void TRemove(Contact entity)
	{
		_contact.Remove(entity);
	}

	public void TUpdate(Contact entity)
	{
		_contact.Update(entity);
	}
}