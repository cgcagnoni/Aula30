using Microsoft.EntityFrameworkCore;
using aula30.Models;

namespace aula30.Models
{
    public class EscolaContext : DbContext 
    {
        public EscolaContext(DbContextOptions<EscolaContext> options):base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instituicao>()
            .ToTable("Instituição")
            .HasKey(t => t.Id);

            modelBuilder.Entity<Aluno>()
            .HasKey(t => t.Id);

            modelBuilder.Entity<Instituicao>()
            .HasMany(t => t.Alunos);
        }

        public DbSet<aula30.Models.Instituicao> Instituicao { get; set; }

        public DbSet<aula30.Models.Aluno> Aluno { get; set; }
    }
}
