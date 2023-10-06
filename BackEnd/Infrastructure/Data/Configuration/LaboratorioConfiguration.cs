using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class LaboratorioConfiguration : IEntityTypeConfiguration<Laboratorio>
{
    public void Configure(EntityTypeBuilder<Laboratorio> builder)
    {
        builder.Property(p => p.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Laboratorio")
            .HasColumnType("int")
            .IsRequired();


        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .IsRequired();

        builder.Property(p => p.Direccion)
            .HasColumnName("Direccion")
            .HasColumnType("varchar")
            .IsRequired();

        builder.Property(p => p.Numero)
            .HasColumnName("Numero")
            .HasColumnType("int")
            .IsRequired();
    }
}
