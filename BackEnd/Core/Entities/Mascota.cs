namespace Core.Entities;
public class Mascota : BaseEntity
{
    public int PropietarioId { get; set; }
    public Propietario? Propietarios { get; set; }

    public int EspecieId { get; set; }
    public Especie? Especies { get; set; }

    public int RazaId { get; set; }
    public Raza? Razas { get; set; }

    public string? Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public ICollection<Cita>? Citas { get; set; }
}