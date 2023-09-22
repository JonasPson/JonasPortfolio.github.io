using Microsoft.AspNetCore.Mvc;
using PortfolioMvc.Views.Projects;

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
            string description = "Lorem ipsum dolor sit amaet consectur adisplici elit. Volupatibus at cupidate laborum quae\r\n" +
                "facare debiti ipsam quasi, natus quisdam officilis fugit\r\n" +
                "repallet veniam totam asperius dolorem nobis.Lorem ipsum dolor sit amaet consectur adisplici elit. Volupatibus at cupidate laborum quae\r\n " +
                "facare debiti ipsam quasi, natus quisdam officilis fugit\r\n                repallet veniam totam asperius dolorem nobis.\r\n   " +
                "Lorem ipsum dolor sit amaet consectur adisplici elit. Volupatibus at cupidate laborum quae\r\n    " +
                "facare debiti ipsam quasi, natus quisdam officilis fugit\r\n                repallet veniam totam asperius dolorem nobis.Lorem ipsum dolor sit amaet consectur adisplici elit. Volupatibus at cupidate laborum quae\r\n " +
                "facare debiti ipsam quasi, natus quisdam officilis fugit\r\n                repallet veniam totam asperius dolorem nobis.";
            return View(new AboutVM { Description = description });
            
        }

        [HttpGet("education")]
        public IActionResult Education()
        {
            return View();
        }

    }
}
