 using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()//şart vermek için ctor yaz iki kez tab tuşuna bas
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("kategori adını boş geçemezsiniz"); //şartlar böyle veriliyor
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("tanımlamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karekter girin");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("lütfen 20 karekterden fazla giriş yapmayınız");
        }
    }
}
