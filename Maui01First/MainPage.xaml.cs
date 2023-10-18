namespace Maui01First
{
    public partial class MainPage : ContentPage
    {
        private int _value = 7;
        public MainPage()
        {
            InitializeComponent();
            lblCounter.Text = _value.ToString();
        }
        private void btnDown_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = (--_value).ToString();
        }

        private void btnUp_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = (++_value).ToString();
        }
    }
}