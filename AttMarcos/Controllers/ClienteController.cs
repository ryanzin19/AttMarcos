using Microsoft.AspNetCore.Mvc;

namespace AttMarcos.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
