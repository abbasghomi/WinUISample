using WinUISample.Domain.Entities;

namespace WinUISample.Applicationz.Common.Interfaces.Repositories
{
    public interface IContactRepository
    {
        Contact AddContact(Contact contact);
        
        List<Contact> GetContacts();
    }
}