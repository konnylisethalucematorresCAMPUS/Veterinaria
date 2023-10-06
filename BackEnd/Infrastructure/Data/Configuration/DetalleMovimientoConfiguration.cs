using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleMovimientoConfiguration : IEntityTypeConfiguration<DetalleMovimiento>
{
    public void Configure(EntityTypeBuilder<DetalleMovimiento> builder)
    {
        builder.ToTable("DetalleMovimiento");

        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_DetalleMovimiento")
           .HasColumnType("int")
           .IsRequired();


        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Id_Medicamento")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Medicamentos) 
            .WithMany(p => p.DetallesMovimientos) 
            .HasForeignKey(p => p.MedicamentoId);


        builder.Property(p => p.Cantidad)
            .HasColumnName("Cantidad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MovimientoMedicamentoId)
            .HasColumnName("Id_Medicamento")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.DetallesMovimientos) 
            .HasForeignKey(p => p.MedicamentoId); 


        builder.Property(p => p.Precio)
            .HasColumnName("Precio")
            .HasColumnType("long")
            .IsRequired();
    }
}
