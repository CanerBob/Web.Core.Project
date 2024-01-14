using Repositories.Layer.AllInterFaces;
using Services.Layer.Abstract;
using System.Linq.Expressions;

namespace Services.Layer.Concrate;
public class WriterMessageManager : IWriterMessageService
{
	private IWriterMessage _writer;

	public WriterMessageManager(IWriterMessage writer)
	{
		_writer = writer;
	}
	public WriterMessage GetById(int id)
	{
		return _writer.GetById(id);
	}

	public List<WriterMessage> GetList()
	{
		return _writer.GetList();
	}

	public List<WriterMessage> GetListByFilter(string p)
	{
		throw new NotImplementedException();
	}

	public List<WriterMessage> GetListRecieverMessage(string p)
	{
		return _writer.GetByFilters(x => x.Receiver == p);
	}

	public List<WriterMessage> GetListSendMessage(string p)
	{
		return _writer.GetByFilters(x => x.Sender == p);
	}
	public void Remove(WriterMessage entity)
	{
		_writer.Remove(entity);
	}

	public void TAdd(WriterMessage entity)
	{
		_writer.Add(entity);
	}

	public void TRemove(WriterMessage entity)
	{
		_writer.Remove(entity);
	}

	public void TUpdate(WriterMessage entity)
	{
		_writer.Update(entity);
	}

	public void Update(WriterMessage entity)
	{
		_writer.Update(entity);
	}
}