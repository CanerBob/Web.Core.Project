using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Models.Layer.AllModels;
public class Person:IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageURl { get; set; }
}