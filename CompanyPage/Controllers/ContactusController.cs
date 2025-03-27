using CompanyPage.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.ObjectModel;

namespace CompanyPage.Controllers
{
    public class ContactusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            var client = new MongoClient();
            var collection = client.GetDatabase("ContactUs").GetCollection<Contact>("Contacts");

            collection.InsertOne(contact);
            return View();
        }
    }
}
