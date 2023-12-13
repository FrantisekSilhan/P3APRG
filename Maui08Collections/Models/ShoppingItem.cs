using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui08Collections.Models
{
    public class ShoppingItem : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _amount;
        private bool _obtained;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }
        public bool Obtained
        {
            get
            {
                return _obtained;
            }
            set
            {
                _obtained = value;
                OnPropertyChanged();
            }
        }

        #region MVVM
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion //MVVM
    }
}
