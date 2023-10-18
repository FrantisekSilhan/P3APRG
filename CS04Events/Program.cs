using CS04Events;

Publisher publisher = new Publisher(10);
Subscriber subscriber = new Subscriber();
publisher.ValueHasChanged += subscriber.OnValueChanged;
publisher.ValueHasChanged += ReportChange;

for (int i = 0; i < 10; i++)
{
    publisher.Value = i;
}
publisher.ValueHasChanged -= ReportChange;
for (int i = 10; i > 0; i--)
{
    publisher.Value = i;
}

static void ReportChange(object sender, ExampleEventArgs e)
{
    Console.WriteLine(string.Format("{0} - {1}", sender.ToString(), e.Value));
}