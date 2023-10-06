namespace API.Dtos;

    public class TratamientoMedicoDto
    {
        public int id {get; set; }
        public string ? Dosis { get; set; }
        public DateTime FechaAdministracion { get; set; }
        public string ? Observacion { get; set; }

    }
