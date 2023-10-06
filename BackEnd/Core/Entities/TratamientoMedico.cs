namespace Core.Entities;

    public class TratamientoMedico : BaseEntity{
        public int IdCita { get; set; }
        public Cita ? Citas { get; set; }

        public int IdMedicamento { get; set; }
        public Medicamento ? Medicamentos { get; set; }
        public string ? Dosis { get; set; }
        public DateTime FechaAdministracion { get; set; }
        public string ? Observacion { get; set; }
    }