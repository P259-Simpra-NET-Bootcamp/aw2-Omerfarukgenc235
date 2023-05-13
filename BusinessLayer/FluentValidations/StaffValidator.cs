using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BusinessLayer.FluentValidations
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad Boş Olamaz!");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("Ad en fazla 50 karakter olabilir!");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad Boş Olamaz!");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Soyad en fazla 50 karakter olabilir!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Boş Olamaz!");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email en fazla 50 karakter olabilir!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarası Boş Olamaz!");
            RuleFor(x => x.Email).MaximumLength(11).WithMessage("Telefon numarası en fazla 11 karakter olabilir!");
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("Doğum Tarihi Boş Olamaz!");
            RuleFor(x => x.AddressLine1).NotEmpty().WithMessage("Adres Boş Olamaz!");
            RuleFor(x => x.AddressLine1).MaximumLength(1000).WithMessage("Adres en fazla 1000 karakter olabilir!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Boş Olamaz!");
            RuleFor(x => x.City).MaximumLength(100).WithMessage("şehir en fazla 100 karakter olabilir!");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Ülke Boş Olamaz!");
            RuleFor(x => x.City).MaximumLength(100).WithMessage("Ülke en fazla 100 karakter olabilir!");
            RuleFor(x => x.Province).NotEmpty().WithMessage("Vilayet Boş Olamaz!");
            RuleFor(x => x.Province).MaximumLength(100).WithMessage("Vilayet en fazla 100 karakter olabilir!");
        }
    }   
}