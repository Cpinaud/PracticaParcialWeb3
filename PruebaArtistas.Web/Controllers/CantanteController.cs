using Microsoft.AspNetCore.Mvc;
using PruebaArtistas.Data.Entidades;
using PruebaArtistas.Logica;

namespace PruebaArtistas.Web.Controllers
{
    public class CantanteController : Controller
    {
        private ICantanteService _CantanteSErvice;

        public CantanteController(ICantanteService CantanteSErvice)
        {
            _CantanteSErvice = CantanteSErvice;
        }
        public IActionResult ListarCantantes()
        {
            return View(_CantanteSErvice.getCantantes());
        }
        [HttpGet]
        public IActionResult AgregarCantante()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarCantante(Cantante cantante)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _CantanteSErvice.InsertCantante(cantante);
            return RedirectToAction("ListarCantantes");
        }
    }
}
