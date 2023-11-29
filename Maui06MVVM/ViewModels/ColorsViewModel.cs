using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui06MVVM.ViewModels
{
    internal class ColorsViewModel : INotifyPropertyChanged
    {
        private int _red;
        private int _green;
        private int _blue;
        private bool _lock;
        private int _number;
        public int Red { get { return _red; } set { _red = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        public int Green { get { return _green; } set { _green = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        public int Blue { get { return _blue; } set { _blue = value; OnPropertyChanged(); OnPropertyChanged("Color"); OnPropertyChanged("Brightness"); OnPropertyChanged("Luminance"); } }
        public Color Color { get { return new Color(Red, Green, Blue); } }
        public int Brightness { get { return (Red + Green + Blue) / 3; } }
        public int Luminance { get { return (int)(0.2126 * Red + 0.7152 * Green + 0.0722 * Blue); } }
        public bool Lock { get { return _lock; } set { _lock = value; OnPropertyChanged(); RandomizeColor?.ChangeCanExecute(); RandomizeColorLimit?.ChangeCanExecute(); } }
        public int Number { get { return _number; } set { _number = value; OnPropertyChanged(); } }

        public Command RandomizeColor { get; set; }
        public Command<int> RandomizeColorLimit { get; set; }
        public ColorsViewModel()
        {
            Red = 100;
            Green = 200;
            Blue = 150;
            Number = 255;
            Lock = true;
            RandomizeColor = new Command(
                () =>
                {
                    Red = Random.Shared.Next(255);
                    Green = Random.Shared.Next(255);
                    Blue = Random.Shared.Next(255);
                },
                () =>
                {
                    return Lock;
                }
            );
            RandomizeColorLimit = new Command<int>(
                (x) =>
                {
                    Red = Random.Shared.Next(x, 255);
                    Green = Random.Shared.Next(x, 255);
                    Blue = Random.Shared.Next(x, 255);
                },
                (x) =>
                {
                    return Lock;
                }
            );
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
