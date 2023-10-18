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
            RedrawUI();
        }

        private void btnUp_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = (++_value).ToString();
            RedrawUI();
        }

        private void btnSet_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                lblCounter.Text = (_value = Convert.ToInt32((sender as Button).Text)).ToString();
            }
            RedrawUI();
        }

        private void RedrawUI()
        {
            btnDown.IsEnabled = _value > 0;
            btnUp.IsEnabled = _value < 100;
        }
    }
}