using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat bilgisini boş geçmeyin!").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz").LessThan(10000).WithMessage("Ürün Fiyatı bu kadar yüksek olamaz, girdiğiniz değeri kontrol edini!");

            RuleFor(z => z.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
        }
    }
}
