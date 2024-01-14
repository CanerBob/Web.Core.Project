using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Portfolio
{

	[Key]
	public int PortfolioId { get; set; }
	public string Name { get; set; }
	public string ImageUrl { get; set; }
	public string ProjectUrl { get; set; }
	public string ImageUrl2 { get; set; }
	public string Platform { get; set; }
	public string Price { get; set; }
	public bool Status { get; set; }
	public string? Image1 { get; set; }
	public int Value { get; set; }
}