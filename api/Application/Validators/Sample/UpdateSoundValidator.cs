using Application.Requests.Sample;
using FluentValidation;

namespace Application.Validators.Sample
{
    public class UpdateSoundValidator : AbstractValidator<UpdateSoundRequest>
    {
        public UpdateSoundValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();

            new CreateSoundValidator();
        }
    }
}