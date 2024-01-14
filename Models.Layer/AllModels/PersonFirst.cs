using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class PersonFirst
{
	[Key]
	public int PersonId { get; set; }
	public string Name { get; set; }
	public string Lastname { get; set; }
	public string UserName { get; set; }
	public string Mail { get; set; }
	public string Password { get; set; }
	public string ConfirmPassword { get; set; }
	public string ImageUrl { get; set; }
	public bool Status { get; set; }
	public List<PersonMessage> PersonMessages { get; set; }
}