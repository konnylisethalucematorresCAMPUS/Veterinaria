using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Configuration;
public class TratamientoMedicoConfiguration : IEntityTypeConfiguration<TratamientoMedico>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TratamientoMedico> builder)
    {
        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_TratamientoMedico")
           .HasColumnType("int")
           .IsRequired();


        builder.Property(p => p.CitaId)
            .HasColumnName("Id_Cita")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Citas) 
            .WithMany(p => p.TratamientosMedicos) 
            .HasForeignKey(p => p.CitaId); 

        builder.Property(p => p.MedicamentoId)
            .HasColumnName("Id_Cita")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Medicamentos) 
            .WithMany(p => p.TratamientosMedicos) 
            .HasForeignKey(p => p.MedicamentoId);

        builder.Property(p => p.Dosis)
            .HasColumnName("Dosis")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.FechaAdministracion)
            .HasColumnName("FechaAdministracion")
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.Observacion)
            .HasColumnName("Observacion")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();




    }
}
