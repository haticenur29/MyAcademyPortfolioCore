using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStatisticsComponent(PortfolioContext context): ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.experienceCount = context.Experiences.Count();
            ViewBag.referenceCount = context.Testimonials.Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.projectCount = context.Projects.Count();
            return View();
        }
    }
}
