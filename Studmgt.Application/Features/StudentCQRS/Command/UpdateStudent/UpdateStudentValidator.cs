using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.StudentCQRS.Command.UpdateStudent
{

        public class UpdateStudentValidator : AbstractValidator<UpdateStudentCommand>
        {
            public UpdateStudentValidator()
            {
            RuleFor(p => p.Sex)
            .NotEmpty().WithMessage("{Male/Female} is required.")
            .NotNull();

            RuleFor(p => p.StudentName)
               .NotEmpty().WithMessage("{Full Name} is required.");

            RuleFor(p => p.Age)
                .NotEmpty().WithMessage("{age} is required.")
                .GreaterThan(0).WithMessage("{age} should be greater than zero.");
        }
    }
}
       