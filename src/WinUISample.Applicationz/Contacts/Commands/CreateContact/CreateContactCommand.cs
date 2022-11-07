using AutoMapper;
using MediatR;
using WinUISample.Applicationz.Common.Interfaces.Repositories;
using WinUISample.Applicationz.Contacts.Models;
using WinUISample.Domain.Entities;

namespace WinUISample.Applicationz.Contacts.Commands.CreateContact;

public record CreateContactCommand : IRequest<ContactDto>
{
    public string Name { get; init; } = string.Empty;
}

public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, ContactDto>
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;

    public CreateContactCommandHandler(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }

    public async Task<ContactDto> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var contact = new Contact
        {
            Name = request.Name
        };

        _contactRepository.AddContact(contact);

        return _mapper.Map<ContactDto>(contact);
    }
}
