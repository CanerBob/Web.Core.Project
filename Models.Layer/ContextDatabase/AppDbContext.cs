using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Models.Layer.ContextDatabase;
public class AppDbContext:IdentityDbContext<Person,PersonRole,int>
{
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<PersonFirst> PersonFirsts { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Sservice> Sservices { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<PersonMessage> PersonMessages { get; set; }
    public DbSet<UserMessage> UserMessages { get; set; }
    public DbSet<Test1> Test1s { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<WriterMessage> WriterMessages { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
        optionsBuilder.UseSqlServer("Data Source=CANER\\SQLEXPRESS;Integrated Security=True;Database=WebCoreProjectDb3;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
	}
}