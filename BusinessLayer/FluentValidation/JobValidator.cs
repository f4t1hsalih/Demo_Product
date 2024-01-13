using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        //Fluent Validation Business Katmanındaki Şartları Koymaya Yarar
        public JobValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Meslek Adını Boş Geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Meslek Adı Minumum 3 Karekter Olmalıdır");
        }
    }
}
