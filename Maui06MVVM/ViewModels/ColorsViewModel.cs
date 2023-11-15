using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui06MVVM.ViewModels
{
    internal class ColorsViewModel : INotifyPropertyChanged
    {
        private int _red;
        public int Red { get { return _red; } set { _red = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        private int _green;
        public int Green { get { return _green; } set { _green = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        private int _blue;
        public int Blue { get { return _blue; } set { _blue = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        public Color Color { get { return new Color(Red, Green, Blue); } }
        public int Brightness { get { return (Red + Green + Blue) / 3; } }
        public int Luminance { get { return (int)(0.2126 * Red + 0.7152 * Green + 0.0722 * Blue); } }

        public ColorsViewModel()
        {
            Red = 100;
            Green = 200;
            Blue = 150;
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
