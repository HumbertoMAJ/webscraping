using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebScrapping.Models;

namespace WebScrapping.Data
{
    public class AlimentoMap : IEntityTypeConfiguration<Alimento>
    {
        public void Configure(EntityTypeBuilder<Alimento> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Nome).HasMaxLength(1000);
            builder.Property(x => x.NomeCF).HasMaxLength(1000);
            builder.Property(x => x.Grupo).HasMaxLength(1000);

            // para ter um melhor controle das entidades que são mapeadas criei um mapeamento
           
        }
    }
}
