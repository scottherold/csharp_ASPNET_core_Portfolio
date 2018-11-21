using Microsoft.AspNetCore.Mvc;
namespace portfolio
{
    public class MasterController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }
    }
}