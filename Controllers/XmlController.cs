using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Microsoft.AspNetCore.Mvc;
using MiBibliotecaAPI.Models;
using MiBibliotecaAPI.Services;
using System.Collections.Generic;

namespace MiBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlController : ControllerBase
    {
        private readonly XmlManager _xmlManager;

        public XmlController(XmlManager xmlManager)
        {
            _xmlManager = xmlManager;
        }

        [HttpGet]
        public IActionResult GetLibros()
        {
            var libros = _xmlManager.LeerLibros();
            return Ok(libros);
        }

        [HttpPost]
        public IActionResult PostLibro(Libro libro)
        {
            var libros = _xmlManager.LeerLibros();
            libros.Add(libro);
            _xmlManager.GuardarLibros(libros);
            return Ok(libro);
        }
    }
}
