using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Musica> Musica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=VALENTINLEON;Initial Catalog=Musica;Integrated Security=True;");
        }

    }

    public class Musica
    {
        [Key]
        public int ID_CANCION { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Duracion { get; set; }
    }




}