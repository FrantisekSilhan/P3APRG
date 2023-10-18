namespace CS04Events
{
    internal class Publisher
    {
        private int _value = 0;

        public Publisher(int value)
        {
            _value = value;
        }

        public int Value
        {
            get { return _value; }
            set
            {
                ValueHasChanged?.Invoke(this, new ExampleEventArgs(value, _value));
                _value = value;
            }
        }

        public event ExampleEventHandler ValueHasChanged; // metoda
    }
}
