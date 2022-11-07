using WinUISample.Applicationz.Common.Mappings;
using WinUISample.Domain.Entities;

namespace WinUISample.Applicationz.Contacts.Models
{
    public class ContactDto : IMapFrom<Contact>
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
