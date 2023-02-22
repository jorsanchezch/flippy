using FluentValidation.Results;

namespace FluentValidation
{
    public static class AbstractValidatorExtensions
    {
        public static ValidationResult Validate<T>(this AbstractValidator<T> validator, T instance, bool throwException)
        {
            var result = validator.Validate(instance);

            if (throwException)
                if (!result.IsValid)
                    throw new ValidationException(result.Errors);

            return result;
        }
    }
}
