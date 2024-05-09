using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;

namespace First_App.Server.Validators
{
    public class EditCardColumnRequestValidator : AbstractValidator<EditCardColumnRequest>
    {
        public EditCardColumnRequestValidator()
        {
            RuleFor(x => x.Name).MaximumLength(150);
            RuleFor(x => x.BoardId).NotEmpty();
        }
    }
}
