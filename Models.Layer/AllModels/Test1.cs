using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Test1
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
