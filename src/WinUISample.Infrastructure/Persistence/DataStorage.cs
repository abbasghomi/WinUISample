using WinUISample.Domain.Entities;

namespace WinUISample.Infrastructure.Persistence
{
    public class DataStorage : IDataStorage
    {
        public List<Contact> Contacts { get; set; } = new List<Contact> { new Contact {Id=Guid.NewGuid(),Name="Name 1" },
                                                                          new Contact {Id=Guid.NewGuid(),Name="Name 2" },
                                                                          new Contact {Id=Guid.NewGuid(),Name="Name 3" },
                                                                          new Contact {Id=Guid.NewGuid(),Name="Name 4" },
                                                                          new Contact {Id=Guid.NewGuid(),Name="Name 5" },
        };
    }
}
