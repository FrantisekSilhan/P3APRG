using Maui08Collections.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui08Collections.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ShoppingItem> _items = new ObservableCollection<ShoppingItem>();
        private int _x;
        private ShoppingItem _item = new ShoppingItem();
        private ShoppingItem _selected = new ShoppingItem();
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

        public ShoppingItem Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }
        public ShoppingItem Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Items.Add(new ShoppingItem { Id = 0, Name = "Borůvky" });
            Items.Add(new ShoppingItem { Id = 1, Name = "Chléb" });
            X = Random.Shared.Next();
            CreateCommand = new Command(
            () =>
            {
                Items.Add(new ShoppingItem { Id = Items.Count, Name = Item.Name, Amount = Item.Amount, Obtained = Item.Obtained });
                Item = new ShoppingItem();
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
