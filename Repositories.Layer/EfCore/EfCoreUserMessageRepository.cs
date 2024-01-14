
using Microsoft.EntityFrameworkCore;

namespace Repositories.Layer.EfCore;
public class EfCoreUserMessageRepository : GenericRepository<UserMessage>, IUserMessage
{
	public List<UserMessage> GetUserMessageWithUser()
	{
		using (var app = new AppDbContext())
		{
			return app.UserMessages.Include(x=>x.Person).ToList();
		};
	}
}