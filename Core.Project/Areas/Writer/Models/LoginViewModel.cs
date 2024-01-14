using System.ComponentModel.DataAnnotations;

namespace Core.Project.Areas.Writer.Models;
public class LoginViewModel
{
    [Display(Name ="Kullanıcı Adınızı Giriniz")]
    [Required(ErrorMessage ="Kullanıcı Adı Zorunludur")]
    public string UserName { get; set; }
    [Display(Name ="Şifrenizi Giriniz")]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}