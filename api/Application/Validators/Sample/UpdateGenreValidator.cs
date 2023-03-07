using Application.Requests.Sample;
using FluentValidation;

namespace Application.Validators.Sample
{
    public class UpdateGenreValidator : AbstractValidator<UpdateGenreRequest>
    {
        public UpdateGenreValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty();

            new CreateGenreValidator();
        }
    }
}