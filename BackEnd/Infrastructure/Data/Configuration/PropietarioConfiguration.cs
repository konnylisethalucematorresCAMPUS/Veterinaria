using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class PropietarioConfiguration : IEntityTypeConfiguration<Propietario>
{
    public void Configure(EntityTypeBuilder<Propietario> builder)
    {   
        builder.Property(p => p.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Propietario")
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
        
    }
}
