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
using System.Windows.Shapes;
using BusinessObjects;

namespace Demo
{
    /// <summary>
    /// Interaction logic for AllShopContacts.xaml
    /// </summary>
    public partial class AllShopContacts : Window
    {
        public AllShopContacts(MailingList AllContacts)
        {
           
            InitializeComponent();
            string Preferred_Contact = null;
            foreach (int i in AllContacts.ids)
            {
                Customer c = AllContacts.find(i);
                switch (c.PreferredContact)
                {
                    case 0:
                        Preferred_Contact = "Email";
                        break;
                    case 1:
                        Preferred_Contact = "Skype";
                        break;
                    case 2:
                        Preferred_Contact = "Telephone";
                        break;
                }
                    
                
                Shop_Contacts.Items.Add(String.Format("ID: {0} | First Name: {1} | Last Name: {2} | Email: {3} | Skype ID: {4} | Telephone: {5} || Preferred Contact: {6}",
                    c.ID.ToString(), c.Name, c.LastName, c.Email, c.Skype, c.Telephone.ToString(), Preferred_Contact));
            }
        }
    }
}
