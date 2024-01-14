using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class SocialMedia
{
	[Key]
	public int SocialMediaId { get; set; }
	public string Name { get; set; }
	public string Url { get; set; }
	public string Icon { get; set; }
	public bool Status { get; set; }
}
