using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFluent
{
    class BaseValidate : AbstractValidator<Base>
    {
        public BaseValidate()
        {
            RuleFor(customr => customr.Surname).NotNull();
        }
    }
}
