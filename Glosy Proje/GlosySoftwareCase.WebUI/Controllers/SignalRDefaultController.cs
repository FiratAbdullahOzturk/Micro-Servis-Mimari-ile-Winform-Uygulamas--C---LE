using Microsoft.AspNetCore.Mvc;

namespace GlosySoftwareCase.WebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignalrProductList()
        {
            return View();
        }
    }
}
