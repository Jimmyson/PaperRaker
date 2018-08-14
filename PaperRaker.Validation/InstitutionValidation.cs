using FluentValidation;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Validation
{
    public class InstitutionValidation : AbstractValidator<Institution>
    {
        public InstitutionValidation()
        {
            RuleFor(i => i.Id).NotNull().NotEmpty().NotEqual(0);

            RuleFor(i => i.Name).NotNull().NotEmpty();
            RuleFor(i => i.City).NotNull().NotEmpty();
            RuleFor(i => i.Country).NotNull().NotEmpty();
        }
    }
}