using System.ComponentModel.DataAnnotations;

namespace Core.Project.Models;
public class RegisterViewModel
{
	[Required(ErrorMessage = "Adınızı Giriniz")]
	public string FirstName { get; set; }
	[Required(ErrorMessage = "Soyadınızı Giriniz")]
	public string LastName { get; set; }
	[Required(ErrorMessage = "Kullanıcı Adınız Giriniz")]
	public string UserName { get; set; }
	[Required(ErrorMessage = "Şifrenizi Giriniz")]
	[DataType(DataType.Password)]
	public string Password { get; set; }
	[Required(ErrorMessage = "Şifrenizi Tekrar Giriniz")]
	[DataType(DataType.Password)]
	[Compare(nameof(Password), ErrorMessage = "Şifreniz Aynı Değil")]
	public string ConfirmPassword { get; set; }
	[Required(ErrorMessage = "Mail Adresinizi Giriniz")]
	[DataType(DataType.EmailAddress)]
	public string Email { get; set; }
}
