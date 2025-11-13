using Microsoft.EntityFrameworkCore;
using personagens_mvc.Models;
namespace personagens_mvc.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
        public DbSet<Personagem> tabelaPersonagem{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Mago>("Mago")
            .HasValue<Guerreiro>("Guerreiro");
        }
    }
}