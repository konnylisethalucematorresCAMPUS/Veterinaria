namespace Core.Entities;
    public class Raza : BaseEntity
    {
        public int EspecieId { get; set; }
        public Especie ? Especies { get; set; }
        
        public string ? Nombre { get; set; }
        public ICollection<Mascota> ? Mascotas { get; set; }

    }
