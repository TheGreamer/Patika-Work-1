using FluentValidation;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Utilities;

namespace PatikaClassWork1.Validators
{
    public class CreateBookValidator : AbstractValidator<CreateBook>
    {
        public CreateBookValidator()
        {
            RuleFor(b => b.AuthorId)
                .NotEmpty().WithMessage(Message.NOT_EMPTY);

            RuleFor(b => b.Name)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .Length(3, 30).WithMessage(Message.NAME_LENGTH_ERROR);

            RuleFor(b => b.Description)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .Length(5, 500).WithMessage(Message.DESCRIPTION_LENGTH_ERROR);

            RuleFor(b => b.PublishDate)
                .NotEmpty().WithMessage(Message.NOT_EMPTY)
                .InclusiveBetween(new(1800, 1, 1), DateTime.Now).WithMessage(Message.DATE_ERROR);
        }
    }
}