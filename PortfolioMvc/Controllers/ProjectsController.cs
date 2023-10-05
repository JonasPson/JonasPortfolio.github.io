using Microsoft.AspNetCore.Mvc;
using PortfolioMvc.Models;
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
            var model = new AboutVM
            {
                FirstText = "I am a recently graduated Full Stack Developer with a unique background as a graphic designer and a former professional football player. My adventures have taken me around the world, and I have also run my own photography business for nearly six years. This multifaceted experience has endowed me with a distinctive ability to approach development projects in a creative and methodical manner.",
                SecondText = "Previously, I worked in real estate photography in Stockholm, a role that demands precision, speed, and effective communication. This experience has equipped me with a keen eye for detail and the capability to handle high workloads on short notice.", 
                ThirdText = "As the owner of my own photography firm, I've also had the opportunity to develop my business acumen and administrative skills. It has provided me with valuable insights into managing all aspects of projects, from conceptualization to delivery.", 
                FourthText = "My background as a professional football player has taught me the importance of discipline, goal-oriented work, and above all, teamwork. These qualities have been invaluable in my transition to becoming a successful developer.", 
                FifthText = "My academic journey at North Park University in Chicago gave me the technical foundation in graphic design and photography that I now combine with my development skills. It's the perfect complement to my current role as a Full Stack Developer. With a passion for problem-solving and a creative inclination, I look forward to bringing these skills to every challenge I face as a Full Stack Developer. I am a self-driven and dedicated individual, ready to propel development projects forward with my knowledge and experiences."
            };
            return View(model);            
        }

        [HttpGet("education")]
        public IActionResult Education()
        {
            return View();
        }

    }
}
