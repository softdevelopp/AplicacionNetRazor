using AplicacionNetRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AplicacionNetRazor.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        //Poner aquí los modelos
        public DbSet<Curso> Curso { get; set; }
    }
}
