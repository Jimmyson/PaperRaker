﻿using FluentValidation;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Validation
{
    public class PaperValidation : AbstractValidator<Paper>
    {
        public PaperValidation()
        {
            RuleFor(p => p.PaperId).NotNull().NotEmpty().NotEqual(0);
            
            RuleFor(p => p.Title).NotNull().NotEmpty();
            RuleFor(p => p.PeerReviewed).NotNull().NotEmpty();
            RuleFor(p => p.PageCount).NotNull().NotEmpty();

            RuleForEach(p => p.Contributors).NotNull();
        }
    }
}