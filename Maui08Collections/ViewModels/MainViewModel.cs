using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui08Collections.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _x;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            X = Random.Shared.Next();
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
