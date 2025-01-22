﻿using FluentValidation;
using kider_app.Helpers.DTOs.Account;

namespace kider_app.Helpers.Validators.Account;

public class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(x => x.EmailOrUsername)
         .NotEmpty()
         .NotNull()
         .MinimumLength(3)
         .WithMessage("Minimum 3 simvol daxil edin")
         .MaximumLength(30)
         .WithMessage("Maximum 30 simvol daxil edin");

        RuleFor(x => x.Password)
        .NotEmpty()
        .NotNull()
        .MinimumLength(4)
        .WithMessage("Minimum 4 simvol daxil edin")
        .Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")
        .WithMessage("Password tipini duzgun daxil edin");
    }
}
