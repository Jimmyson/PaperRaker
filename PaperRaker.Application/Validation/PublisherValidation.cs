using FluentValidation;
using PaperRaker.Core.System;

namespace PaperRaker.Application.Validation
{
    public class PublisherValidation : AbstractValidator<Publisher>
    {
        public PublisherValidation()
        {
            RuleFor(i => i.PublisherId).NotNull().NotEmpty().NotEqual(0);

            RuleFor(i => i.Name).NotNull().NotEmpty();
            RuleFor(i => i.City).NotNull().NotEmpty();
            RuleFor(i => i.Country).NotNull().NotEmpty();
        }
    }
}