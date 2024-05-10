using First_App.Server.DataTransferObjects.Requests;
using FluentValidation;

namespace First_App.Server.Validators
{
    public class EditBoardRequestValidator : AbstractValidator<EditBoardRequest>
    {
        public EditBoardRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(150);
        }
    }
}
