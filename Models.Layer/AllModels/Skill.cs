﻿using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Skill
{
	[Key]
	public int SkillId { get; set; }
	public string Title { get; set; }
	public string Value { get; set; }
	public string IkonUrl { get; set; }
}
