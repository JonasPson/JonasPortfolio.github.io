using Microsoft.AspNetCore.Mvc;

namespace PortfolioMvc.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
