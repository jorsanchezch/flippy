using Domain.Entities.Sample;
using FluentValidation;
using Application.Requests.Sample;

namespace Application.Validators.Sample
{
    public class CreateGenreValidator : AbstractValidator<GenreRequest>
    {
        public CreateGenreValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}