using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> myContacts = Contact.GetAll();
      return View(myContacts);
    }

    [HttpGet("/contacts/add")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult UpdateContacts()
    {
      Contact newContact = new Contact(Request.Form["name"], Request.Form["phone-number"], Request.Form["address"]);
      newContact.Save();
      List<Contact> myContacts = Contact.GetAll();
      return View("Index", myContacts);
    }

  }
}
