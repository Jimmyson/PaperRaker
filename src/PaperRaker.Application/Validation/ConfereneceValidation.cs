using FluentValidation;
using PaperRaker.Core.System;

namespace PaperRaker.Application.Validation
{
    public class ConfereneceValidation : AbstractValidator<Conference>
    {
        public ConfereneceValidation()
        {
            RuleFor(i => i.ConferenceId)
				.NotNull()
				.NotEmpty()
				.NotEqual(uint.MinValue);

            RuleFor(i => i.Name)
				.NotNull()
				.NotEmpty();

			// TODO: Replace with Area Entity links
            RuleFor(i => i.City)
				.NotNull()
				.NotEmpty();
            RuleFor(i => i.Country)
				.NotNull()
				.NotEmpty();
        }
    }
}