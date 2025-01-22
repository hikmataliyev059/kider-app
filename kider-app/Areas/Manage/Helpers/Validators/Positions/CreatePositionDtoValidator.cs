using FluentValidation;
using kider_app.Areas.Manage.Helpers.DTOs.Positions;

namespace kider_app.Areas.Manage.Helpers.Validators.Positions;

public class CreatePositionDtoValidator : AbstractValidator<CreatePositionDto>
{
    public CreatePositionDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .WithMessage("Minimum 3 simvol daxil edin")
            .MaximumLength(30)
            .WithMessage("Maximum 30 simvol daxil edin");
    }
}
