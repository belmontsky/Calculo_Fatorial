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
            if (!ModelState.IsValid)
            {
                //Adicionei essa validação para não ficar retornando o view mesmo com erro
                if (ModelState["Numero"].Errors.Count > 0)
                {
                    ModelState.AddModelError("Numero", "O número tem que ser não negativo.");
                }

                return View(model);
            }

            return View(model);
        }
    }
}
