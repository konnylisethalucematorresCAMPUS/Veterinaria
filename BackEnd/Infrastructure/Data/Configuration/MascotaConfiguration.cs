using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
{
    public void Configure(EntityTypeBuilder<Mascota> builder)
    {
        builder.Property(p => p.Id)
            .HasAnnotation("MySqlValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Laboratorio")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.PropietarioId)
            .HasColumnName("Id_Propietario")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Propietarios)//Nombre de la tabla a la que estamos llamando en plural 
            .WithMany(p => p.Mascotas)// nombre de tabla en la que estamos trabajando plural 
            .HasForeignKey(p => p.PropietarioId); //Nombre del Id de la FK


        builder.Property(p => p.EspecieId)
            .HasColumnName("Id_Especie")
            .HasColumnType("int")
            .IsRequired();      

            builder.HasOne(p => p.Especies)
            .WithMany(p => p.Mascotas)
            .HasForeignKey(p => p.EspecieId);


        builder.Property(p => p.RazaId)
            .HasColumnName("Id_Raza")
            .HasColumnType("int")
            .IsRequired();      

            builder.HasOne(p => p.Razas)
            .WithMany(p => p.Mascotas)
            .HasForeignKey(p => p.RazaId);

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.FechaNacimiento)
            .HasColumnName("FechaNacimiento")
            .HasColumnType("datetime")
            .IsRequired();
    }
}
