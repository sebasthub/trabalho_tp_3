using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cinemaxx
{
    public partial class CinemaxxContext : DbContext
    {
        public CinemaxxContext()
            : base("name=CinemaxxContext")
        {
        }

        public virtual DbSet<fileira> fileira { get; set; }
        public virtual DbSet<filme> filme { get; set; }
        public virtual DbSet<ingresso> ingresso { get; set; }
        public virtual DbSet<pagamento> pagamento { get; set; }
        public virtual DbSet<programacao> programacao { get; set; }
        public virtual DbSet<sala> sala { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<fileira>()
                .Property(e => e.indentificador)
                .IsUnicode(false);

            modelBuilder.Entity<fileira>()
                .HasMany(e => e.ingresso)
                .WithOptional(e => e.fileira1)
                .HasForeignKey(e => e.fileira);

            modelBuilder.Entity<filme>()
                .Property(e => e.classificacao)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.categoria)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.idioma)
                .IsUnicode(false);

            modelBuilder.Entity<filme>()
                .Property(e => e.preco)
                .HasPrecision(19, 4);

            modelBuilder.Entity<filme>()
                .HasMany(e => e.programacao)
                .WithOptional(e => e.filme1)
                .HasForeignKey(e => e.filme);

            modelBuilder.Entity<ingresso>()
                .HasMany(e => e.pagamento)
                .WithOptional(e => e.ingresso1)
                .HasForeignKey(e => e.ingresso);

            modelBuilder.Entity<pagamento>()
                .Property(e => e.nome_filme)
                .IsUnicode(false);

            modelBuilder.Entity<pagamento>()
                .Property(e => e.sala)
                .IsUnicode(false);

            modelBuilder.Entity<pagamento>()
                .Property(e => e.fileira)
                .IsUnicode(false);

            modelBuilder.Entity<pagamento>()
                .Property(e => e.valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<programacao>()
                .HasMany(e => e.ingresso)
                .WithOptional(e => e.programacao1)
                .HasForeignKey(e => e.programacao);

            modelBuilder.Entity<sala>()
                .Property(e => e.indentificador)
                .IsUnicode(false);

            modelBuilder.Entity<sala>()
                .HasMany(e => e.fileira)
                .WithOptional(e => e.sala1)
                .HasForeignKey(e => e.sala);

            modelBuilder.Entity<sala>()
                .HasMany(e => e.programacao)
                .WithOptional(e => e.sala1)
                .HasForeignKey(e => e.sala);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.ingresso)
                .WithOptional(e => e.usuario1)
                .HasForeignKey(e => e.usuario);
        }
    }
}
