using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MailingList store = new MailingList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Find_btn_Click(object sender, RoutedEventArgs e)
        {
            Find_btn.Visibility = Visibility.Collapsed;
            Find_Grid.Visibility = Visibility.Visible;
        }
        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Delete_btn.Visibility = Visibility.Collapsed;
            Delete_Grid.Visibility = Visibility.Visible;
        }
        private void AddCustomer_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
