using Microsoft.AspNetCore.Mvc;
using Daniel_Teste1.Models;

namespace Daniel_Teste1.Controllers
{
    public class FatorialController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FatorialModel());
        }

        [HttpPost]
        public IActionResult Index(FatorialModel model)
        {
            if (model.Numero < 0)
            {
                ModelState.AddModelError("Numero", "O número precisa ser não negativo.");
            }
            return View(model);
        }
    }
}
