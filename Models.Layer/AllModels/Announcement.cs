using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Announcement
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
    public string Content { get; set; }
}