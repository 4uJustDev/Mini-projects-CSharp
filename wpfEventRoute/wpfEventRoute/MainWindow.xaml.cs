﻿using System;
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

namespace wpfEventRoute
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

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBox_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            //lbLogs
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbLogs.Items.Add($"All_MouseDown \n sender={sender} \n) e.Source={e.Source}");
        }

        private void All_MouseEnter(object sender, MouseEventArgs e)
        {
            lbLogs.Items.Add($"All_MouseEnter \n sender={sender} \n) e.Source={e.Source}");
        }
    }
}
