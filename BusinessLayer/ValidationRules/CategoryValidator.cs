using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("You cannot pass the category name field empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("You cannot pass the description field empty");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please make at least 3 characters input");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Please do not enter more than 20 characters");


            
        }
    }
}
