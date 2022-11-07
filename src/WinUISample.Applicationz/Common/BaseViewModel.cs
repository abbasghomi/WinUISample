using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using MediatR;

namespace WinUISample.Applicationz.Common
{
    public class BaseViewModel : ObservableRecipient
    {
        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= Ioc.Default.GetRequiredService<ISender>();
    }
}