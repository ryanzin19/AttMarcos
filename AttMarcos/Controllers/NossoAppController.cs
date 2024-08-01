using Microsoft.AspNetCore.Mvc;

namespace AttMarcos.Controllers
{
    public class NossoAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
