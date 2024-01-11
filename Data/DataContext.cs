using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agborala.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace agborala.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }


        public DbSet<Destino> Agborala { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destino>().HasData(
                new Destino {Id = 1, Nome = "Fernando de Noronha", Descricao = "Uma das praias mais lindas do mundo", Imgurl = "https://pixabay.com/pt/photos/fernando-de-noronha-mar-ilha-2581811/"},
                new Destino {Id = 2, Nome = "Gramado", Descricao = "Um dos destinos mais requisitados do Brasil",  Imgurl = "https://pixabay.com/pt/photos/igreja-pedra-constru%C3%A7%C3%A3o-medieval-5837123/"},
                new Destino {Id = 3, Nome = "Rio de Janeiro", Descricao = "Visita ao Cristo Redentor",  Imgurl = "https://pixabay.com/pt/photos/p%C3%A3o-de-a%C3%A7%C3%BAcar-bonde-bondinho-1679285/"}                
            );
        }


    }
}