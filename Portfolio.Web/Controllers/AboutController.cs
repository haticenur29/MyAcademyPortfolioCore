using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class AboutController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var about = context.Abouts.FirstOrDefault();
            return View(about);
        }

        public IActionResult UpdateAbout()
        {
            var about = context.Abouts.FirstOrDefault();
            return View(about);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
