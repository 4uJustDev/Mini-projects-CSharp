using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            meLogs.Text += "1";
        }
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            meLogs.Text += "2";
        }
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var xIsChecked = (e.Source as ToggleButton)?.IsChecked;
            meLogs.Text += $"3({xIsChecked})";
        }

        
    }
}
