using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
    public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
    {
          
public void Configure(EntityTypeBuilder<Especie> builder)
    {
        
        builder.Property(p => p.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Especie")
            .HasColumnType("int")
            .IsRequired();


        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .IsRequired();

    }
}
