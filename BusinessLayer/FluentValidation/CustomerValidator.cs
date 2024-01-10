using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    internal class CustomerValidator : AbstractValidator<Customer>
    {
        //Fluent Validation Business Katmanındaki Şartları Koymaya Yarar
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri Adı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehri Bilgisi Boş Geçilemez");
        }
    }
}
