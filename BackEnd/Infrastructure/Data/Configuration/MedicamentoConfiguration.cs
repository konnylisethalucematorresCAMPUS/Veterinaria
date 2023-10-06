using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Configuration;
public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Medicamento> builder)
    {
        builder.ToTable("Medicamento");

        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_Medicamento")
           .HasColumnType("int")
           .IsRequired();

        builder.Property(p => p.Nombre)
           .HasColumnName("Nombre")
           .HasColumnType("varchar")
           .HasMaxLength(40)
           .IsRequired();

        builder.Property(p => p.CantidadDisponible)
           .HasColumnName("CantidadDisponible")
           .HasColumnType("int")
           .IsRequired();

        builder.Property(p => p.Precio)
           .HasColumnName("Precio")
           .HasColumnType("int")
           .IsRequired();
    

        builder.Property(p => p.LaboratorioId)
            .HasColumnName("Id_Laboratorio")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Laboratorios)//Nombre de la tabla a la que estamos llamando en plural 
            .WithMany(p => p.Medicamentos)// nombre de tabla en la que estamos trabajando plural 
            .HasForeignKey(p => p.LaboratorioId); //Nombre del Id de la FK

    }
}
