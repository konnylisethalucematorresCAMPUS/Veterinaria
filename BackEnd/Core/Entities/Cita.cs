using System.Reflection;

namespace Core.Entities;

public class Cita : BaseEntity
{

    public int MascotaId { get; set; }
    public Mascota? Mascotas { get; set; }

    public DateTime Fecha { get; set; }
    public DateTime Hora { get; set; }
    public string? Motivo { get; set; }

    public int VeterinarioId { get; set; }
    public Veterinario? Veterinarios { get; set; }

    public ICollection<TratamientoMedico> ? TratamientosMedicos { get; set; }


}
