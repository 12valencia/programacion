using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiBibliotecaAPI.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
    }
}