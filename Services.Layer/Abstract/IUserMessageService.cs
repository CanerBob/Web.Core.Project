namespace Services.Layer.Abstract;
public interface IUserMessageService:IGenericService<UserMessage>
{
	List<UserMessage> GetUserMessageWithPerson();
}