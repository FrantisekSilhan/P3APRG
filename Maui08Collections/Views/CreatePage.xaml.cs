namespace Maui08Collections.Views;

public partial class CreatePage : ContentPage
{
    public CreatePage()
    {
        InitializeComponent();
        BindingContext = (Application.Current.MainPage! as AppShell).MVM;
    }

    private void btnBack_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..", true, new Dictionary<string, object> { });
    }

    private void btnCreate_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..", true, new Dictionary<string, object> { });
    }
}