using AutoMapper;
using MediatR;
using WinUISample.Applicationz.Common.Interfaces.Repositories;
using WinUISample.Applicationz.Contacts.Models;

namespace WinUISample.Applicationz.TodoItems.Queries.GetTodoItemsWithPagination;

public record GetContactsQuery : IRequest<List<ContactDto>>
{
}

public class GetContactQueryHandler : IRequestHandler<GetContactsQuery, List<ContactDto>>
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;

    public GetContactQueryHandler(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository=contactRepository;
        _mapper = mapper;
    }

    public async Task<List<ContactDto>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<ContactDto>>(_contactRepository.GetContacts());
    }
}
