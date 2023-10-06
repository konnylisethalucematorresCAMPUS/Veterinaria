using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("Cita");

        builder.Property(p => p.Id)
           .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
           .HasColumnName("Id_Cita")
           .HasColumnType("int")
           .IsRequired();

        builder.Property(p => p.MascotaId)
            .HasColumnName("Id_Mascota")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Mascotas)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.MascotaId); 

        builder.Property(p => p.Fecha)
            .HasColumnName("Fecha")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(p => p.Hora)
            .HasColumnName("Hora")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(p => p.Motivo)
            .HasColumnName("Motivo")
            .HasColumnType("varchar")
            .HasMaxLength(30)
            .IsRequired();
        
   builder.Property(p => p.VeterinarioId)
            .HasColumnName("Id_Veterinario")
            .HasColumnType("int")
            .IsRequired();

         builder.HasOne(p => p.Veterinarios)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.VeterinarioId);



    }
}
