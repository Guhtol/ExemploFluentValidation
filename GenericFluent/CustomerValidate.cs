using FluentValidation;

namespace GenericFluent
{
    public class CustomerValidate : AbstractValidator<Customer>
    {
        public CustomerValidate()
        {
            RuleFor(customr => customr.Forename).NotNull();
        }
    }
}
