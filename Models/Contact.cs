using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address; //may refactor this as another object

    private static List<Contact> _myContacts;

    public Contact (string name, string phoneNumber, string address)
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

    public string GetAddress()
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

  }
}
