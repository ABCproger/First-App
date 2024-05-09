using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;

namespace First_App.Server.Validators
{
    public class EditCardRequestValidator : AbstractValidator<EditCardRequest>
    {
        public EditCardRequestValidator()
        {
            RuleFor(x => x.CardColumnId).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(150);
            RuleFor(x => x.Description).MaximumLength(1500);
        }
    }
}
