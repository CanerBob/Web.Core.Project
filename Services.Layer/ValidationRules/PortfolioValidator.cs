﻿using FluentValidation;

namespace Services.Layer.ValidationRules;
public class PortfolioValidator:AbstractValidator<Portfolio>
{
    public PortfolioValidator()
    {
		RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
		RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
		RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel2 Alanı Boş Geçilemez");
		RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alanı Boş Geçilemez");
		RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
		RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı Min 5 Karakter Olmalıdır");
		RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı Max 100 Karakter Olmalıdır");
	}
}
