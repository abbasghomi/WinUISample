using FluentValidation;
using WinUISample.Applicationz.Contacts.Commands.CreateContact;

namespace WinUISample.Applicationz.TodoItems.Commands.CreateTodoItem;

public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
{
    public CreateContactCommandValidator()
    {
        RuleFor(v => v.Name)
            .NotEmpty();
    }
}
