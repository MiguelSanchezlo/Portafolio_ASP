using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Services;
using System.Diagnostics;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyecto _resProyecto;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyecto resProyecto)
        {
            _logger = logger;
            _resProyecto = resProyecto;
        }

        public IActionResult Index()
        {
            var proyecto = _resProyecto.obtenerProyectos().Take(3).ToList();
            var modeloP = new HomeIndexViewModel()
            {
                eProyectos = proyecto
            };

            //var persona = new PersonaViewModel
            //{
            //    nombre = "Miguel",
            //    edad = 20
            //};
            return View(modeloP);
        }

        public IActionResult Proyectos()
        {
            var proyecto = _resProyecto.obtenerProyectos().ToList();
            var modeloP = new HomeIndexViewModel()
            {
                eProyectos = proyecto
            };

            return View(modeloP);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gracias(ContactoViewModel contacto)
        {
            var modelo = contacto;
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
