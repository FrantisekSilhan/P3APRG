namespace Maui04Resources
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                object x;
                if (Resources.TryGetValue("MainColor", out x) && (x is Color))
                {
                    (sender as Button).BackgroundColor = (Color)x;
                }
            }
        }
    }
}