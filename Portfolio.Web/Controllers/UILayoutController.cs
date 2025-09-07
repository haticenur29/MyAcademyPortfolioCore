using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Portfolio.Web.Context;
namespace Portfolio.Web.Controllers
{
    public class UILayoutController() : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
