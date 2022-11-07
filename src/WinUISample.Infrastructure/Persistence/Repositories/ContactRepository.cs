using WinUISample.Applicationz.Common.Interfaces.Repositories;
using WinUISample.Domain.Entities;

namespace WinUISample.Infrastructure.Persistence.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDataStorage _dataStorage;

        public ContactRepository(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        public List<Contact> GetContacts()
        {
            return _dataStorage.Contacts;
        }

        public Contact AddContact(Contact contact)
        {
            contact.Id = Guid.NewGuid();

            _dataStorage.Contacts.Add(contact);

            return contact;
        }
    }
}
