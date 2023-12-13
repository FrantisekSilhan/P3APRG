using Maui08Collections.ViewModels;
using Maui08Collections.Views;

namespace Maui08Collections
{
    public partial class AppShell : Shell
    {
        public MainViewModel MVM { get; } = new MainViewModel();
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CreatePage), typeof(CreatePage));
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        }
    }
}
