using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfCommand
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

        private void CommandNew_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(nameof(CommandNew_Executed));
        }

        private void CommandSave_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(nameof(CommandSave_Executed));
        }

        private void CommandSave_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void CommandMyAdd_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }

    public class MyCommands 
    {
        public static RoutedCommand Add { get; private set; } = new RoutedCommand ("Add", typeof(MainWindow));
    }
}
