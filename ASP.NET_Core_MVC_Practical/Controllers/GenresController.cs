using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC_Practical.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
