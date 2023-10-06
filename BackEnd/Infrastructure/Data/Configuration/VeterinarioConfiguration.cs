using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class VeterinarioConfiguration : IEntityTypeConfiguration<Veterinario>
{
    public void Configure(EntityTypeBuilder<Veterinario> builder)
    {
        builder.ToTable("Veterinario");

        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_Veterinario")
           .HasColumnType("int")
           .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.CorreoElectronico)
            .HasColumnName("CorreoElectronico")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();


        builder.Property(p => p.Telefono)
            .HasColumnName("Telefono")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Especialidad)
           .HasColumnName("Especialidad")
           .HasColumnType("varchar")
           .HasMaxLength(40)
           .IsRequired();

    }
}
