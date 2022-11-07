using WinUISample.Domain.Entities;

namespace WinUISample.Infrastructure.Persistence
{
    public interface IDataStorage
    {
        List<Contact> Contacts { get; set; }
    }
}