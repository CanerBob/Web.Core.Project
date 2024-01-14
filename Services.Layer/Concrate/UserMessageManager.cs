using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class UserMessageManager : IUserMessageService
{
	private IUserMessage _userMessage;

	public UserMessageManager(IUserMessage userMessage)
	{
		_userMessage = userMessage;
	}
	public UserMessage GetById(int id)
	{
		return _userMessage.GetById(id);
	}

	public List<UserMessage> GetList()
	{
		return _userMessage.GetList();
	}

	public List<UserMessage> GetListByFilter()
	{
		throw new NotImplementedException();
	}

	public List<UserMessage> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public List<UserMessage> GetUserMessageWithPerson()
	{
		return _userMessage.GetUserMessageWithUser();
	}

	public void TAdd(UserMessage entity)
	{
		_userMessage.Add(entity);
	}

	public void TRemove(UserMessage entity)
	{
		_userMessage.Remove(entity);
	}

	public void TUpdate(UserMessage entity)
	{
		_userMessage.Update(entity);
	}
}