using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad-soyad boş olamaz");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter giriniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş olamaz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş olamaz")
                 .Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harf içermelidir.")
                 .Matches(@"[a-z]+").WithMessage("Sifre en az bir küçük harf içermelidir.")
                 .Matches(@"[0-9]+").WithMessage("Sifre en az bir rakam içermelidir.");
        }
    }
}
