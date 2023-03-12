using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("You can't pass the name of the author empty");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("You can't pass the surname of the author empty");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("You cannot pass the part of me empty");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("You cannot pass the title part empty");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Please make at least 2 characters input");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Please do not enter more than 50 characters");
        }
    }
}
