namespace Core.Entities;

    public class TratamientoMedico : BaseEntity{
        public int CitaId { get; set; }
        public Cita ? Citas { get; set; }

        public int MedicamentoId { get; set; }
        public Medicamento ? Medicamentos { get; set; }
        
        public string ? Dosis { get; set; }
        public DateTime FechaAdministracion { get; set; }
        public string ? Observacion { get; set; }
    }