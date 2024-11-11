using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*namespace MiBibliotecaAPI.Services
{
    public class XmlManager
    {
        
    }
}*/

using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using MiBibliotecaAPI.Models;

namespace MiBibliotecaAPI.Services
{
    public class XmlManager
    {
        private readonly string _filePath = "libros.xml";

        public List<Libro> LeerLibros()
        {
            if (!File.Exists(_filePath)) return new List<Libro>();

            using var stream = new FileStream(_filePath, FileMode.Open);
            var serializer = new XmlSerializer(typeof(List<Libro>));
            return (List<Libro>)serializer.Deserialize(stream);
        }

        public void GuardarLibros(List<Libro> libros)
        {
            using var stream = new FileStream(_filePath, FileMode.Create);
            var serializer = new XmlSerializer(typeof(List<Libro>));
            serializer.Serialize(stream, libros);
        }
    }
}
