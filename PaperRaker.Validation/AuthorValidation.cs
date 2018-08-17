using FluentValidation;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Validation
{
    public class AuthorValidation : AbstractValidator<Author>
    {
        public AuthorValidation()
        {
            RuleFor(a => a.AuthorId).NotNull().NotEmpty().NotEqual(0);
            
            RuleFor(a => a.Given).NotNull().NotEmpty();
            RuleFor(a => a.Family).NotNull().NotEmpty();
        }
    }
}