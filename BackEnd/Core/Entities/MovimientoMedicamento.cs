using System.Data;

namespace Core.Entities;

    public class MovimientoMedicamento : BaseEntity{
      public int IdMedicamento { get; set; }
      public Medicamento ? Medicamentos { get; set;}
       
      public int Cantidad { get; set; }
      public DateTime Fecha { get; set; }

      public ICollection<DetalleMovimiento> ? DetallesMovimientos { get; set; }

    }
