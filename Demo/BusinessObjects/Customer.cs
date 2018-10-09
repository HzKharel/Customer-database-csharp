using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class Customer
    {
        private int _customerID;
        private int _customerTelephone;
        private string _customerName;
        private string _customerLastName;
        private string _customerEmail;
        private string _customerSkype;


        public int ID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public int Telephone
        {
            get
            {
                return _customerTelephone;
            }
            set
            {
                _customerTelephone = value;
            }
        }
        
        public string Name
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }

        }
        public string LastName
        {
            get
            {
                return _customerLastName;
            }
            set
            {
                _customerLastName = value;
            }
        }
             public string Email
        {
            get
            {
                return _customerEmail;
            }
            set
            {
                _customerEmail = value;
            }
        }
             public string Skype
        {
            get
            {
                return _customerSkype;
            }
            set
            {
                _customerSkype = value;
            }

        }
    }

    
    
}
