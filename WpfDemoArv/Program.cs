using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemoArv
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();

            var mainPanel = new StackPanel();

            //var clicker1 = new SimpleClicker();
            //mainPanel.Children.Add(clicker1.Panel);

            //var clicker2 = new SimpleClicker();
            //mainPanel.Children.Add(clicker2.Panel);

            var clicker1 = new ClickerPanel();
            mainPanel.Children.Add(clicker1);

            var clicker2 = new ClickerPanel();
            mainPanel.Children.Add(clicker2);

            window.Content = mainPanel;
            app.Run(window);
        }
    }
}
