﻿using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Experience
{
	[Key]
	public int ExperienceId { get; set; }
	public string Name { get; set; }
	public string Date { get; set; }
	public string ImageUrl { get; set; }
	public string Description { get; set; }
}
