using System.Windows;
using System.Windows.Controls;

namespace WpfDemoArv
{
    class ClickerPanel : StackPanel
    {
        private readonly Label _label;
        private int _count;

        public ClickerPanel()
        {
            Orientation = Orientation.Horizontal;

            var button = new Button { Content = "Trykk her" };
            _label = new Label();
            button.Click += ButtonClick;

            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
