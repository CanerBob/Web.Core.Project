using System.ComponentModel.DataAnnotations;

namespace Core.Project.API.Dal.Entites;
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}