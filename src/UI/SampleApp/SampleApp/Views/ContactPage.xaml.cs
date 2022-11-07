using Microsoft.UI.Xaml.Controls;
using WinUISample.Applicationz.Contacts.ViewModel;

namespace SampleApp.Views
{
    public sealed partial class ContactPage : Page
    {
        public ContactPage()
        {
            this.InitializeComponent();
            this.DataContext = App.Current.Services. GetService<IContactViewModel>();
        }
    }
}
