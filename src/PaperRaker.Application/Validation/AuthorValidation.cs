using FluentValidation;
using PaperRaker.Core.System;

namespace PaperRaker.Application.Validation
{
    public class AuthorValidation : AbstractValidator<Author>
    {
        public AuthorValidation()
        {
            RuleFor(a => a.AuthorId)
				.NotNull()
				.NotEmpty()
				.NotEqual(uint.MinValue);
            
            RuleFor(a => a.Given)
				.NotNull()
				.NotEmpty();
            RuleFor(a => a.Family)
				.NotNull()
				.NotEmpty();
        }
    }
}