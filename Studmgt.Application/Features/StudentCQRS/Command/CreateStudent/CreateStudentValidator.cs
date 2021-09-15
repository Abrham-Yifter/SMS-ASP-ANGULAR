using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.StudentCQRS.Command.CreateStudent
{
        public class CreateStudentValidator : AbstractValidator<CreateStudentCommand>
        {
            public CreateStudentValidator()
            {
                RuleFor(p => p.StudentName)
                    .NotEmpty().WithMessage("{Name} is required.")
                    .NotNull()
                    .MaximumLength(50).WithMessage("{Name} must not exceed 50 characters.");

                RuleFor(p => p.Sex)
                   .NotEmpty().WithMessage("{Sex} is required.");

            }
        }
    }