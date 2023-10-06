using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class MedicamentoProveedorConfiguration : IEntityTypeConfiguration<MedicamentoProveedor>
{
    public void Configure(EntityTypeBuilder<MedicamentoProveedor> builder)
    {
        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_MedicamentoProveedor")
           .HasColumnType("int")
           .IsRequired();


        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Id_Medicamento")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Medicamentos)
            .WithMany(p => p.MedicamentosProveedores)
            .HasForeignKey(p => p.MedicamentoId);

        builder.Property(p => p.ProveedorId)
            .HasColumnName("Id_Proveedor")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Proveedores)
            .WithMany(p => p.MedicamentosProveedores)
            .HasForeignKey(p => p.ProveedorId);

    }
}
