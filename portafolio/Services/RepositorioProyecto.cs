using portafolio.Models;

namespace portafolio.Services
{
    public interface IRepositorioProyecto
    {
        List<ProyectoViewModel> obtenerProyectos();
    }
    public class RepositorioProyecto : IRepositorioProyecto
    {
        public List<ProyectoViewModel> obtenerProyectos()
        {
            // Simulaion de recepcion de una base de datos
            return new List<ProyectoViewModel>()
            {
                new ProyectoViewModel() {
                    titulo = "Platzi Backend Developer",
                    descripcion = "Desarrollador backend en platzi, trabajando en la creacion y mantenimniento de servicios y APIs.",
                    imagenUrl = "/img/platzi.png",
                    link = "https://platzi.com/ruta/web-backend/"
                },
                new ProyectoViewModel() {
                    titulo = "Platzi Frontend Developer",
                    descripcion = "Desarrollador frontend en platzi, responsable de la implementacion de interfaces de usuario interactivas y responsivas.",
                    imagenUrl = "/img/frontend.jpg",
                    link = "https://platzi.com/ruta/web-frontend/"
                },
                new ProyectoViewModel() {
                    titulo = "Platzi Mobile Developer",
                    descripcion = "Desarrollador mobile en platzi, enfocado en optimizar, corregir y actualizar la aplicacion movil para los estudiantes.",
                    imagenUrl = "/img/mobile.jpg",
                    link = "https://platzi.com/ruta/desarrollo-android/"
                },
                new ProyectoViewModel() {
                    titulo = "Platzi Security Analyst",
                    descripcion = "Analista de seguridad en Platzi, responsable de identificar, mitigar y prevenir amenazas de seguridad para garantizar la protección de los datos de los usuarios.",
                    imagenUrl = "/img/ciber.jpg",
                    link = "https://platzi.com/escuela/ciberseguridad/"
                },
                new ProyectoViewModel()
                {
                    titulo = "Platzi Database Administrator",
                    descripcion = "Administrador de bases de datos en Platzi, encargado de diseñar, implementar y mantener bases de datos escalables y seguras.",
                    imagenUrl = "/img/db.jpeg",
                    link = "https://platzi.com/ruta/base-de-datos/"
                }
            };
        } 
    }
}
