namespace Core.Entities;
public class Mascota : BaseEntity
{
    public int IdPropietario { get; set; }
    public Propietario? Propietario { get; set; }

    public int IdEspecie { get; set; }
    public Especie? Especies { get; set; }

    public int IdRaza { get; set; }
    public Raza? Razas { get; set; }

    public string? Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public ICollection<Cita>? Citas { get; set; }
}