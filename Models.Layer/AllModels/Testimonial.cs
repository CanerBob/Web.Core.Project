using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Testimonial
{
	[Key]
	public int TestimonialID { get; set; }
	public string ClientName { get; set; }
	public string Company { get; set; }
	public string Commend { get; set; }
	public string ImageUrl { get; set; }
}
