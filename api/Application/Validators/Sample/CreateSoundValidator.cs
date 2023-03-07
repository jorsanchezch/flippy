using Domain.ValueObjects.Sample;
using FluentValidation;
using Application.Requests.Sample;

namespace Application.Validators.Sample
{
    public class CreateSoundValidator : AbstractValidator<SoundRequest>
    {
        public CreateSoundValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).MaximumLength(500);
            RuleFor(x => x.Bpm).NotEmpty().InclusiveBetween(1, 300);
            RuleFor(x => x.AudioFile).NotNull();
            RuleFor(x => x.KeyRoot).NotNull().Must(x => Enum.IsDefined(typeof(Note), x));
            RuleFor(x => x.KeyMod).NotNull().Must(x => Enum.IsDefined(typeof(Modification), x));
            RuleFor(x => x.KeyForm).NotNull().Must(x => Enum.IsDefined(typeof(Form), x));
            RuleFor(x => x.CollectionId);
        }
    }
}