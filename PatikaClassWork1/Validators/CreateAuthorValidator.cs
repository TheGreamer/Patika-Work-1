using FluentValidation;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Utilities;

namespace PatikaClassWork1.Validators
{
    public class CreateAuthorValidator : AbstractValidator<CreateAuthor>
    {
        public CreateAuthorValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .Length(3, 30).WithMessage(Message.NAME_LENGTH_ERROR);

            RuleFor(b => b.Surname)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .Length(3, 30).WithMessage(Message.NAME_LENGTH_ERROR);

            RuleFor(b => b.DateOfBirth)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .InclusiveBetween(new(1800, 1, 1), DateTime.Now).WithMessage(Message.DATE_ERROR);
        }
    }
}