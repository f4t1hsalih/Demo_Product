using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //Fluent Validation Business Katmanındaki Şartları Koymaya Yarar
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adı Minumum 3 Karekter Olmalıdır");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok Sayısı Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Sayısı Boş Geçilemez");
        }
    }
}
