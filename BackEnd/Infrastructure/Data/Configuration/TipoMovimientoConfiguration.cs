using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoMovimientoConfiguration : IEntityTypeConfiguration<TipoMovimiento>
{
    public void Configure(EntityTypeBuilder<TipoMovimiento> builder)
    {
        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_TipoMovimiento")
           .HasColumnType("int")
           .IsRequired();

        
        builder.Property(p => p.Descripcion)
            .HasColumnName("Descripcion")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
    }
}