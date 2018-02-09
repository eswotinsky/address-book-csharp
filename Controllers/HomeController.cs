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
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Address newAddress = new Address(Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip-code"]);
            Contact newContact = new Contact(Request.Form["name"], Request.Form["phone-number"], newAddress);
            newContact.Save();
            List<Contact> myContacts = Contact.GetAll();
            return View("Index", myContacts);
        }

        [HttpPost("/contacts/delete")]
        public ActionResult DeleteContacts()
        {
            Contact.ClearAll();
            List<Contact> myContacts = Contact.GetAll();
            return View("Index", myContacts);
        }

    }
}
