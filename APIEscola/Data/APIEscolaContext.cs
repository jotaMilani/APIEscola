// Codigo do Arquivo 
using APIEscola.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Custom model configurations can be added here
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<Turma>().ToTable("Turmas");
            modelBuilder.Entity<Matricula>().ToTable("Matriculas");



        }
    }
}


// =========================================================================================