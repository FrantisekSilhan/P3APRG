using Maui08Collections.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui08Collections.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ShoppingItem> _items;
        private int _x;
        public ObservableCollection<ShoppingItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
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
        public Command CreateCommand { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<ShoppingItem>();
            Items.Add(new ShoppingItem { Id = 1, Name = "Borůvky" });
            Items.Add(new ShoppingItem { Id = 2, Name = "Chléb" });
            X = Random.Shared.Next();
            CreateCommand = new Command(
            () =>
            {
                Items.Add(new ShoppingItem { Id = 1, Name = "Mléko" });
            },
            () =>
            {
                return true;
            });
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
