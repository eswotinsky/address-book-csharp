using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private Address _address;

        private static List<Contact> _myContacts = new List<Contact> {};

        public Contact (string name, string phoneNumber, Address address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public void Save()
        {
            _myContacts.Add(this);
        }

        public static List<Contact> GetAll()
        {
            return _myContacts;
        }

        public static void ClearAll()
        {
            _myContacts.Clear();
        }

    }
}
