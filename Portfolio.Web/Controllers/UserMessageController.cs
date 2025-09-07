using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class UserMessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var messages = context.UserMessages.ToList();
            return View(messages);
        }

        public IActionResult DeleteUserMessage(int id)
        {
            var message = context.UserMessages.Find(id);
            context.UserMessages.Remove(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeMessageToRead(int id) 
        {
            var message = context.UserMessages.Find(id);
            message.IsRead = true;
            context.UserMessages.Update(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeMessageToUnread(int id)
        {
            var message = context.UserMessages.Find(id);
            message.IsRead = false;
            context.UserMessages.Update(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MessageDetail(int id)
        {
            var model = context.UserMessages.Find(id);
            return PartialView("MessgeDetail", model);
        }
    }
}
