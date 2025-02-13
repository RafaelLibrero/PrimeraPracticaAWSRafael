﻿using Microsoft.EntityFrameworkCore;
using PrimeraPracticaAWSRafael.Data;
using PrimeraPracticaAWSRafael.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPracticaAWSRafael.Repositories
{
    public class RepositoryPeliculas
    {
        private PeliculasContext context;
        
        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }

        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await
                this.context.Peliculas.ToListAsync();   
        }

        public async Task<List<Pelicula>> GetPeliculasActoresAsync(string actor)
        {
            return await
                this.context.Peliculas
                .Where(x => x.Actores.Contains(actor))
                .ToListAsync();
        }
    }
}
