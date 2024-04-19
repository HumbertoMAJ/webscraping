using Microsoft.EntityFrameworkCore;
using WebScrapping.Models;

namespace WebScrapping.Data
{
    public class AlimentosDBContext : DbContext
    {
        public AlimentosDBContext(DbContextOptions<AlimentosDBContext> options)
            : base(options)
        {
        }
        //Aqui estou utilizando o Entity Framework para me ajudar no mapeamento para a conexão com o banco
        public DbSet<Alimento> alimentos { get; set; }

        public DbSet<Composicao> composicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlimentoMap());
            modelBuilder.ApplyConfiguration(new ComponenteMap());
            base.OnModelCreating(modelBuilder);
        }

       

    }
}
