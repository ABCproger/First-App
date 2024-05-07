using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;
using System.Data;

namespace First_App.Server.Validators
{
    public class AddCardColumnRequestValidator : AbstractValidator<AddCardColumnRequest>
    {
        public AddCardColumnRequestValidator()
        {
            RuleFor(x => x.Name).MaximumLength(150);
            RuleFor(x => x.BoardId).NotEmpty();
        }
    }
}
