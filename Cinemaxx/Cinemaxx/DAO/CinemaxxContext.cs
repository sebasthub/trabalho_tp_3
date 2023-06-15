using Cinemaxx.Model;
using Microsoft.EntityFrameworkCore;

namespace Cinemaxx.DAO
{
    public class CinemaxxContext : DbContext
    {
        protected CinemaxxContext(DbContextOptions<CinemaxxContext> options)
            : base(options)
        {
        }

        public DbSet<Fileira> fileiras { get; set; }
        public DbSet<Filme> filmes { get; set; }
        public DbSet<Ingresso> ingressos { get; set; }
        public DbSet<Pagamento> pagamentos { get; set; }
        public DbSet<Programacao> programacaos { get; set; }
        public DbSet<Sala> salas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fileira>().ToTable("Fileira");
            modelBuilder.Entity<Filme>().ToTable("Filme");
            modelBuilder.Entity<Ingresso>().ToTable("Ingresso");
            modelBuilder.Entity<Pagamento>().ToTable("Pagamento");
            modelBuilder.Entity<Programacao>().ToTable("Programacao");
            modelBuilder.Entity<Sala>().ToTable("Sala");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

        }

    }
}
