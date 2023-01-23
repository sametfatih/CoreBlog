using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AuthorValidator:AbstractValidator<Author>
	{
		public AuthorValidator()
		{
			RuleFor(a => a.AuthorName).NotEmpty().WithMessage("Yazar adı soyadı boş bırakılamaz.");
			RuleFor(a => a.AuthorMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz.");
			RuleFor(a => a.AuthorPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
		}
	}
}
