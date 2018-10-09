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
        private int _CustomerPreferredContact;


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
        public int PreferredContact
        {
            get
            {
                return _CustomerPreferredContact;
            }
            set
            {
               _CustomerPreferredContact = value;
            }

        }

        public Customer(int id_, string Name_, string LastName_, string Email_, string Skype_,int PreferredContact_, int Telelphone_)
        {
            this._customerID = id_;
            this._customerName = Name_;
            this._customerLastName = LastName_;
            this._customerEmail = Email_;
            this._customerSkype = Skype_;
            this._CustomerPreferredContact = PreferredContact_;
            this._customerTelephone = Telelphone_;
        }
    }

    
    
}
