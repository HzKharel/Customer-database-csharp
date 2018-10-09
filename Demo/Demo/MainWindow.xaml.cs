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
        private BusinessObjects.Validation Customer_Validation = new BusinessObjects.Validation();
        private int Customer_ID_Auto = 10000;
        private int Customer_ID_int;
        private int Telephone_int;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Find_btn_Click(object sender, RoutedEventArgs e)
        {
            Find_btn.Visibility = Visibility.Collapsed;
            Find_Grid.Visibility = Visibility.Visible;
        }
        private void Find_txtbox_Click(object sender, RoutedEventArgs e)
        {
            Find_txtbox.Text = String.Empty;
        }
   

        private void AddCustomer_btn_Click(object sender, RoutedEventArgs e)
        {
           
            if (String.IsNullOrEmpty(CustomerID.Text))
            {
                Customer_ID_Auto++;
                CustomerID.Text = Customer_ID_Auto.ToString();
            }
            string Validate = Customer_Validation.Validate(CustomerID.Text, First_Name.Text, Last_Name.Text, Email.Text, Telephone.Text);
            if(Validate != "Validation Sucessful")
            {
                MessageBox.Show(Validate);
            }
            else
            {
                Int32.TryParse(CustomerID.Text,out Customer_ID_int);
                Int32.TryParse(Telephone.Text, out Telephone_int);
                Customer New_Customer = new Customer(Customer_ID_int, First_Name.Text, Last_Name.Text, Email.Text, SkypeID.Text,PreferredContact.SelectedIndex,Telephone_int);
                store.add(New_Customer);
                AllContacts.Items.Add(String.Format("{0} {1} {2}", New_Customer.ID.ToString(), New_Customer.Name, New_Customer.LastName));

                foreach (UIElement element in TextFields.Children)
                {
                    TextBox textbox = element as TextBox;
                    if (textbox != null)
                    {
                        textbox.Text = String.Empty;
                    }
                }



            }
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Delete_btn.Visibility = Visibility.Collapsed;
            Delete_Grid.Visibility = Visibility.Visible;
        }

        private void Delete_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            Delete_txtbox.Text = String.Empty;
        }

        private void Find_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            Find_txtbox.Text = String.Empty;
        }

        private void Find_btn_2_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Find_txtbox.Text, out Customer_ID_int);
            Customer c = store.find(Customer_ID_int);
            if(c != null)
            {
                
                First_Name.Text = c.Name;
                Last_Name.Text = c.LastName;
                Email.Text = c.Email;
                SkypeID.Text = c.Skype;
                Telephone.Text = c.Telephone.ToString();
                CustomerID.Text = c.ID.ToString();
                PreferredContact.SelectedIndex = c.PreferredContact;
            }
            else
            {
                MessageBox.Show("The Customer with ID:" + Customer_ID_int + " is not found.");
            }
             Find_btn.Visibility = Visibility.Visible;
             Find_Grid.Visibility = Visibility.Collapsed;

        }

        private void Delete_btn_2_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Delete_txtbox.Text, out Customer_ID_int);
            Customer To_Delete = store.find(Customer_ID_int);
            if(To_Delete != null)
            {
                AllContacts.Items.Remove(String.Format("{0} {1} {2}", To_Delete.ID.ToString(), To_Delete.Name, To_Delete.LastName));
                store.delete(Customer_ID_int);
            }
            Delete_btn.Visibility = Visibility.Visible;
            Delete_Grid.Visibility = Visibility.Collapsed;
           
        }
    }
}
