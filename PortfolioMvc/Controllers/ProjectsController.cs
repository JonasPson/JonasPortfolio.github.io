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

        [HttpGet("contact")]
        public IActionResult Contact() 
        {
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
