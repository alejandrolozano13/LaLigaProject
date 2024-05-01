using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Infra.ConexaoBD
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set;}
        public DbSet<Estadio> Estadios { get; set;}
        public DbSet<Jogo> Jogos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogo>()
            .HasOne(j => j.TimeLocal)
            .WithMany(t => t!.JogosComoLocal)
            .HasForeignKey(j => j.TimeLocalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Jogo>()
                .HasOne(j => j.TimeVisitante)
                .WithMany(t => t!.JogosComoVisitante)
                .HasForeignKey(j => j.TimeVisitanteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}