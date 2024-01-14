namespace Repositories.Layer.AllInterFaces;
public interface IUserMessage:IGeneric<UserMessage>
{
	public List<UserMessage> GetUserMessageWithUser();
}
