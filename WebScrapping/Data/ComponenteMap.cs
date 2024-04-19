using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebScrapping.Models;

namespace WebScrapping.Data
{
    public class ComponenteMap : IEntityTypeConfiguration<Composicao>
    {
        public void Configure(EntityTypeBuilder<Composicao> builder)
        {

            builder.HasKey(x =>  x.Id );
            builder.Property(x => x.Codigo).HasMaxLength(1000);
            builder.Property(x => x.Componente).HasMaxLength(1000);
            builder.Property(x => x.Unidades).HasMaxLength(1000);
            builder.Property(x => x.ValorP).HasMaxLength(1000);
            builder.Property(x => x.DesvioP).HasMaxLength(1000);
            builder.Property(x => x.ValorMin).HasMaxLength(1000);
            builder.Property(x => x.ValorMax).HasMaxLength(1000);
            builder.Property(x => x.NumeroD).HasMaxLength(1000);
            builder.Property(x => x.Ref).HasMaxLength(1000);
            builder.Property(x => x.TipoD).HasMaxLength(1000);


        }
    }
}
