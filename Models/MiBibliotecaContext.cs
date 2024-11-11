using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
namespace MiBibliotecaAPI.Models
{
    public class MiBibliotecaContext
    {
        
    }
}*/

using Microsoft.EntityFrameworkCore;

namespace MiBibliotecaAPI.Models
{
    public class MiBibliotecaContext : DbContext
    {
        public MiBibliotecaContext(DbContextOptions<MiBibliotecaContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; }
    }
}