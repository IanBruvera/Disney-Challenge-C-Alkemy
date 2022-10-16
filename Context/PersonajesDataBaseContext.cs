using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Disney_Proyect_Akemy;
using Disney_Proyect_Akemy.Models;
using System.Reflection.Emit;


namespace Disney_Proyect_Akemy.Context
{
    public class PersonajesDataBaseContext : DbContext
    {
        public PersonajesDataBaseContext(DbContextOptions<PersonajesDataBaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PersonajesPorPeliculas>().HasKey(x => new { x.PeliculasId, x.PersonajesId });

            builder.Entity<PersonajesPorSeries>().HasKey(x => new { x.SeriesId, x.PersonajesId });

           
        }


        public DbSet<Personajes> Personajes { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<PersonajesPorPeliculas> PersonajesPorPeliculas { get; set; }
        public DbSet<PersonajesPorSeries> PersonajesPorSeries { get; set; }

        


    }



    
}
