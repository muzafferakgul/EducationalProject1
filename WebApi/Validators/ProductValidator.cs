using Entities.Concrete;
using FluentValidation;

namespace WebApi.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotNull().WithMessage("Ürün ismi boş olamaz").NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(x => x.ProductName).Length(2, 5).WithMessage("Ürün adı 2 ile 5 karakter arası olmalı.");
        }
    }
}
