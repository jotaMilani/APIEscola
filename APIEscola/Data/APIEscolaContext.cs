// Codigo do Arquivo 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Custom model configurations can be added here
        }
    }
}


// =========================================================================================