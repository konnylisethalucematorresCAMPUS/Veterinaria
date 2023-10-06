using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RazaConfiguration : IEntityTypeConfiguration<Raza>
{
    public void Configure(EntityTypeBuilder<Raza> builder)
    {
        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_Raza")
           .HasColumnType("int")
           .IsRequired();


        builder.Property(p => p.EspecieId)
            .HasColumnName("Id_Especie")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Especies) 
            .WithMany(p => p.Razas)
            .HasForeignKey(p => p.EspecieId); 

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

    }
}
