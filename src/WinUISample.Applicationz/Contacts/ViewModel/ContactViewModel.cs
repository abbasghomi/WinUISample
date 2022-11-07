using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WinUISample.Applicationz.Common;
using WinUISample.Applicationz.Contacts.Commands.CreateContact;
using WinUISample.Applicationz.Contacts.Models;
using WinUISample.Applicationz.TodoItems.Queries.GetTodoItemsWithPagination;

namespace WinUISample.Applicationz.Contacts.ViewModel
{
    public partial class ContactViewModel : BaseViewModel, IContactViewModel
    {
        public string Name { get { return "Contact Page"; } }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddContactCommand))]
        public string? _contactNameInput;

        public ObservableCollection<ContactDto> Contacts { get; set; }

        private bool CanAddContact(string name) => !string.IsNullOrEmpty(name);

        private bool _initialized;

        private async Task InitializeAsync()
        {
            if (!_initialized)
            {
                var contacts = await GetContactsFromStorageAsync();

                Contacts = new ObservableCollection<ContactDto>(contacts);

                _initialized = true;
            }
        }

        [RelayCommand]
        private async Task DataContextChangedAsync()
        {
            await InitializeAsync();
        }

        [RelayCommand(CanExecute = nameof(CanAddContact))]
        private async Task AddContactAsync(string name)
        {
            var result = await Mediator.Send(new CreateContactCommand { Name = name });
            Contacts.Add(result);

            ContactNameInput = string.Empty;
            OnPropertyChanged(nameof(ContactNameInput));
        }

        private async Task<List<ContactDto>> GetContactsFromStorageAsync()
        {
            var result = await Mediator.Send(new GetContactsQuery());

            return result;
        }

    }
}
