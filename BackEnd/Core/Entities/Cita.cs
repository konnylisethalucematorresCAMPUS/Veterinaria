using System.Reflection;

namespace Core.Entities;

public class Cita : BaseEntity
{

    public int IdMascota { get; set; }
    public Mascota? Mascotas { get; set; }

    public DateTime Fecha { get; set; }
    public DateTime Hora { get; set; }
    public string? Motivo { get; set; }

    public int IdVeterinario { get; set; }
    public Veterinario? Veterinarios { get; set; }



}
