using Microsoft.AspNetCore.Mvc;

namespace pro_1.Controllers
{
    public class home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
