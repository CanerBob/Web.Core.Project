using System.Linq.Expressions;

namespace Services.Layer.Abstract;
public interface IWriterMessageService:IGenericService<WriterMessage>
{
	List<WriterMessage> GetListSendMessage(string p);
	List<WriterMessage> GetListRecieverMessage(string p);
}