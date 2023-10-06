using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Configuration;
public class MovimientoMedicamentoConfiguration : IEntityTypeConfiguration<MovimientoMedicamento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MovimientoMedicamento> builder)
    {
        builder.Property(p => p.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Laboratorio")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Id_Medicamento")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.MovimientosMedicamentos)
            .HasForeignKey(p => p.MedicamentoId);

        builder.Property(p => p.Cantidad)
            .HasColumnName("Cantidad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Fecha)
            .HasColumnName("Fecha")
            .HasColumnType("datetime")
            .IsRequired();


    }
}
