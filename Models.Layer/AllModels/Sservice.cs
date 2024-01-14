using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Sservice
{
	[Key]
	public int ServiceId { get; set; }
	public string Title { get; set; }
	public string ImageUrl { get; set; }
}