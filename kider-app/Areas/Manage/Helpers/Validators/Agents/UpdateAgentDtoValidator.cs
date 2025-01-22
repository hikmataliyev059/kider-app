using FluentValidation;
using kider_app.Areas.Manage.Helpers.DTOs.Agents;

namespace kider_app.Areas.Manage.Helpers.Validators.Agents;

public class UpdateAgentDtoValidator : AbstractValidator<UpdateAgentDto>
{
    public UpdateAgentDtoValidator()
    {
        RuleFor(x => x.Name)
          .NotEmpty()
          .NotNull()
          .MinimumLength(3)
          .WithMessage("Minimum 3 simvol daxil edin")
          .MaximumLength(30)
          .WithMessage("Maximum 30 simvol daxil edin");

        RuleFor(x => x.PositionId)
          .NotEmpty()
          .NotNull()
          .WithMessage("Duzgun position daxil edin");
    }
}
