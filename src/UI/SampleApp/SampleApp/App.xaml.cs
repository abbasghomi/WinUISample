
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using SampleApp.Extensions;

namespace SampleApp
{

    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

        public Ioc Services => Ioc.Default;

        public App()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.ConfigureDI();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            Ioc.Default.ConfigureServices(serviceProvider);

            this.InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;
    }
}
