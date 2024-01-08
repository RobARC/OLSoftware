using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OLSofwareDos.Models;

namespace OLSofwareDos.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Aspirante> Aspirantes { get; set; }
        public DbSet<EstadoPrueba> EstadoPruebas { get; set; }
        public DbSet<NivelPrueba> NivelPruebas { get; set; } 
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<PruebaSeleccion> PruebaSeleccions { get; set; }
        public DbSet<TipoPrueba> TipoPruebas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.seed();
            base.OnModelCreating(modelBuilder);
        }
    }
    
    
}