using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;

namespace First_App.Server.Validators
{
    public class AddBoardRequestValidator : AbstractValidator<AddBoardRequest>
    {
        public AddBoardRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(150);
        }
    }
}
