using System.Windows.Controls;

namespace WpfDemoArv
{
    class SimpleClicker
    {
        private Label _label;
        private int _count;
        public StackPanel Panel { get; }

        public SimpleClicker()
        {
            Panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            var button = new Button {Content = "Trykk her"};
            _label = new Label();
            button.Click += ButtonClick;

            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
