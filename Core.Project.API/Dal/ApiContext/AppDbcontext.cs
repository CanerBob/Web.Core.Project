using Core.Project.API.Dal.Entites;
using Microsoft.EntityFrameworkCore;

namespace Core.Project.API.Dal.ApiContext
{
	public class AppDbcontext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=CANER\\SQLEXPRESS;Integrated Security=True;Database=WebCoreProject3Api;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}
		public DbSet<Category> Categories { get; set; }
	}
}
