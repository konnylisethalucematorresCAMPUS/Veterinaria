namespace Core.Entities;

    public class Medicamento : BaseEntity{
        public string ? Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public int Precio { get; set; }
        
        public int LaboratorioId { get; set; }
        public Laboratorio ? Laboratorios { get; set; }

        public ICollection<DetalleMovimiento> ? DetallesMovimientos { get; set; }
        public ICollection<MedicamentoProveedor> ? MedicamentosProveedores { get; set; }
        public ICollection<MovimientoMedicamento> ? MovimientosMedicamentos { get; set; }
        public ICollection<TratamientoMedico> ? TratamientosMedicos { get; set; }
    }
