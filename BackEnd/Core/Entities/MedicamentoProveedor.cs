namespace Core.Entities;
    public class MedicamentoProveedor : BaseEntity
    {
        public int IdMedicamento { get; set; }
        public Medicamento ? Medicamentos { get; set; }

        public int IdProveedor { get; set; }
        public Proveedor ? Proveedores { get; set; }
    }
