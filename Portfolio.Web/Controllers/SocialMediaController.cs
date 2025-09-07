using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SocialMediaController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var socialmedia = context.SocialMedias.ToList();
            return View(socialmedia);
        }

        public IActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia model)
        {
            context.SocialMedias.Update(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
