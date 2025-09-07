using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ContactController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var contact = context.ContactInfos.FirstOrDefault();
            return View(contact);
        }

        public IActionResult UpdateContact()
        {
            var contact = context.ContactInfos.FirstOrDefault();
            return View(contact);
        }

        [HttpPost]
        public IActionResult UpdateContact(ContactInfo contact)
        {
            context.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
