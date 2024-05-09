using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;

namespace First_App.Server.Validators
{
    public class AddCardRequestValidator : AbstractValidator<AddCardRequest>
    {
        public AddCardRequestValidator()
        {
            RuleFor(x => x.CardColumnId).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(150);
            RuleFor(x => x.Description).MaximumLength(1500);
        }
    }
}
