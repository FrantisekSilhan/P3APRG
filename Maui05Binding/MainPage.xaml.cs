using Maui05Binding.Models;

namespace Maui05Binding
{
    public partial class MainPage : ContentPage
    {
        public Models.Person Borivoj { get; set; }
        public MainPage()
        {
            Borivoj = new Models.Person { FirstName = "Bořivoj", Age = 18 };
            InitializeComponent();
            lblPersonName.BindingContext = Borivoj;
            lblPersonName.SetBinding(Label.TextProperty, nameof(Person.FirstName));
            lblPersonAge.BindingContext = Borivoj;
            lblPersonAge.SetBinding(Label.TextProperty, nameof(Person.Age));
            entPersonName.BindingContext = Borivoj;
            entPersonName.SetBinding(Entry.TextProperty, nameof(Person.FirstName), BindingMode.TwoWay);
        }

        private void sliValue_ValueChanged(object sender, EventArgs e)
        {
            lblValue.Text = sliValue.Value.ToString();
        }
    }
}