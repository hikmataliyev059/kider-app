using FluentValidation;
using kider_app.Helpers.DTOs.Account;

namespace kider_app.Helpers.Validators.Account;

public class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(x => x.FullName)
          .NotEmpty()
          .NotNull()
          .MinimumLength(3)
          .WithMessage("Minimum 3 simvol daxil edin")
          .MaximumLength(30)
          .WithMessage("Maximum 30 simvol daxil edin");

        RuleFor(x => x.Email)
         .NotEmpty()
         .NotNull()
         .MinimumLength(3)
         .WithMessage("Minimum 3 simvol daxil edin")
         .EmailAddress()
         .WithMessage("Email tipini duzgun daxil edin");

        RuleFor(x => x.Password)
        .NotEmpty()
        .NotNull()
        .MinimumLength(4)
        .WithMessage("Minimum 4 simvol daxil edin")
        .Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")
        .WithMessage("Password tipini duzgun daxil edin");

        RuleFor(x => x.ConfirmPassword)
        .NotEmpty()
        .NotNull()
        .MinimumLength(4)
        .WithMessage("Minimum 4 simvol daxil edin")
        .Equal(x => x.Password)
        .WithMessage("Passwords don't matches");

    }
}
