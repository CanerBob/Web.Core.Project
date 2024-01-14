using System.ComponentModel.DataAnnotations;

namespace Core.Project.Areas.Writer;
public class PersonRegisterViewModel
{
    [Required(ErrorMessage="Adınızı Giriniz")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Soyadınızı Giriniz")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Kullanıcı Adınız Giriniz")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Şifrenizi Giriniz")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Şifrenizi Tekrar Giriniz")]
    [Compare(nameof(Password),ErrorMessage ="Şifreniz Aynı Değil")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Mail Adresinizi Giriniz")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public string ImageUrl { get; set; }
}