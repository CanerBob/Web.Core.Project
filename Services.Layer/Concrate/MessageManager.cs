using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class MessageManager : IMessageService
{
	private IMessage _message;

	public MessageManager(IMessage message)
	{
		_message = message;
	}

	public Message GetById(int id)
	{
		return _message.GetById(id);
	}

	public List<Message> GetList()
	{
		return _message.GetList();
	}

	public List<Message> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<Message> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public void TAdd(Message entity)
	{
		_message.Add(entity);
	}

	public void TRemove(Message entity)
	{
		_message.Remove(entity);
	}

	public void TUpdate(Message entity)
	{
		_message.Update(entity);
	}
}