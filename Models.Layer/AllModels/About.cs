using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class About
{
	[Key]
	public int AboutId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string Age { get; set; }
	public string Mail { get; set; }
	public string Phone { get; set; }
	public string Adress { get; set; }
	public string ImageUrl { get; set; }
}
