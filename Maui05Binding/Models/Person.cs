using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui05Binding.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private int _age;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged(); }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
