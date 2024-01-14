using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class UserMessage
{
	[Key]
	public int MessageID { get; set; }
	public string Title { get; set; }
	public string Content { get; set; }
	public DateTime Date { get; set; }
	public bool Status { get; set; }
	public int PersonId { get; set; }
	public PersonFirst Person { get; set; }
}
