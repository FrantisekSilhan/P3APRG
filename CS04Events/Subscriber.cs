namespace CS04Events
{
    internal class Subscriber
    {
        public void OnValueChanged(object sender, ExampleEventArgs e)
        {
            Console.WriteLine(string.Format("{0} -> {1}", e.PreviousValue, e.Value));
        }
    }
}
