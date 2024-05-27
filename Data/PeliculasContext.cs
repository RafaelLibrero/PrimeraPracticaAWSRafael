using Microsoft.EntityFrameworkCore;
using PrimeraPracticaAWSRafael.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPracticaAWSRafael.Data
{
    public class PeliculasContext: DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
